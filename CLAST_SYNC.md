# Clast upstream sync & release process

This fork republishes specific Google/gRPC .NET libraries under `Clast.*` ids. We keep up with
upstream and publish on a unified version. The mechanism spans four sibling forks under
[`clast-project`](https://github.com/clast-project):

| Repo | Upstream | Republished packages |
|---|---|---|
| `gax-dotnet` | googleapis/gax-dotnet | `Clast.Google.Api.Gax`, `.Rest`, `.Grpc` |
| `google-api-dotnet-client` | googleapis/google-api-dotnet-client | `Clast.Google.Apis.Core`, `.Google.Apis`, `.Auth`, `.Storage.v1`, `.Bigquery.v2` |
| `google-cloud-dotnet` | googleapis/google-cloud-dotnet | `Clast.Google.Cloud.Storage.V1`, `.BigQuery.V2`, `.BigQuery.Storage.V1` |
| `grpc-dotnet` | grpc/grpc-dotnet | `Clast.Grpc.Auth` |

## How it works

1. **Detect** — `.github/workflows/upstream-watch.yml` runs weekly in each repo. It reads
   `.clast/upstream-baseline.json` (the upstream NuGet versions we last synced to) and compares
   each against nuget.org. If any upstream package shipped a newer stable version, it opens or
   updates a single issue labeled **`upstream-sync`** in that repo.

2. **Sync** — a scheduled **Claude routine** reads open `upstream-sync` issues across the four
   repos. For each, it fetches `upstream`, merges `upstream/main` into a `sync/upstream-<date>`
   branch, resolves the Clast port conflicts (System.Text.Json instead of Newtonsoft.Json,
   trimming/AOT, the `-p:Clast=true` packaging flag), builds + tests, refreshes
   `.clast/upstream-baseline.json` to the new versions, and opens a PR that closes the issue.
   **A human reviews and merges** the sync PR.

3. **Publish** — once the relevant sync PRs are merged, push a unified release tag `v<X.Y.Z>` on
   **`google-api-dotnet-client`**. Its `clast-publish.yml` packs all `Clast.*` packages across the
   four repos at that single version and pushes them to NuGet.org. The Clast version is its own
   line (independent of each library's upstream version).

## Running the sync locally (recommended)

The scheduled cloud **Claude routine** (step 2) currently can't complete a sync: its
environment was granted **read-only** GitHub credentials, so it can merge/build in its
sandbox but can never `git push` the branch or open the PR — the run ends with nothing on
GitHub. It also reinstalls the .NET SDK every run (~16 min+). Until that environment is
re-granted write access (and given a prebuilt .NET image), run the sync **locally**: a dev
box has the .NET 10 SDK and all four sibling forks checked out under one parent dir, which
is exactly what the cross-repo build needs.

Steps (example is this repo; take the target versions from the `upstream-sync` issue body):

1. From a clean `main`, fetch upstream and branch. The upstream default branch is `main`
   for the googleapis repos but `master` for grpc/grpc-dotnet — detect it, don't assume:
   `UB=$(git remote show upstream | sed -n 's/.*HEAD branch: //p')`
   then `git checkout -b sync/upstream-<YYYY-MM-DD> main` and `git merge upstream/$UB`.
2. Resolve conflicts, always **preserving the Clast ports**:
   - `.csproj`: keep the Clast `ProjectReference`s to the STJ support libs, the
     `netstandard2.0` `System.Text.Json` ref, and the `Clast=true` metadata group; **take
     upstream's `<Version>` bump** (it auto-merges — don't `checkout --ours` the whole file,
     which would revert it).
   - generated `.cs`: keep upstream's functional change, re-apply the STJ attribute.
3. **Sweep for un-ported Newtonsoft that auto-merged in.** Upstream regenerates clients with
   Newtonsoft; only lines *both* sides edited conflict, so new upstream properties slip in
   un-ported. `grep -rn 'Newtonsoft' <republished-project-dirs>` and replace
   `[Newtonsoft.Json.JsonPropertyAttribute("x")]` → `[System.Text.Json.Serialization.JsonPropertyName("x")]`.
   int64 (`long`) body fields need only the plain attribute — the source-gen serializer
   handles long-as-string globally. Compare the count against pre-merge `main` to be sure
   the support libs didn't regress.
4. **Regenerate `*.JsonContext.cs`** (the committed AOT registry) against the new client
   surface: `python Tools/ClastJsonContextGen/regenerate.py`, then review the diff.
   Do this *before* building — it handles both directions. A request type upstream
   **removed** would otherwise show up as `CS0426: type 'XxxRequest' does not exist`, and one
   upstream **added** wouldn't show up at all: it silently falls back to reflection, an AOT
   gap the build can't catch. See `Tools/ClastJsonContextGen/README.md` for what the script
   derives and what it preserves.
5. **Build + test exactly as `.github/workflows/clast-ci.yml` does:**
   `dotnet build` the Storage.v1 and Bigquery.v2 generated clients (all TFMs, incl. net10),
   and `dotnet test` `Google.Apis.Tests` + `Google.Apis.Auth.Tests` (`-c Release`). Then
   validate the publish path itself: `dotnet pack <proj> -c Release -p:Clast=true` — the
   package should come out as `Clast.<Name>.<version>.nupkg`.
6. Update `.clast/upstream-baseline.json` to the merged versions.
7. Commit, push, open a PR with `Closes #<issue>`. A human still merges it, then pushes the
   unified `v*` release tag on `google-api-dotnet-client` to publish.

## Requirements

- `clast-publish.yml` pushes to NuGet.org via **trusted publishing** (OIDC, `NuGet/login`) — no API key
  secret. It relies on a trusted-publishing policy on the `curt_hagenlocher` nuget.org account for
  `clast-project/google-api-dotnet-client` + `clast-publish.yml`; renaming the workflow file breaks it.
  The watch workflow needs no secrets — it uses the built-in `GITHUB_TOKEN`.
- Adding a new fork to the system: drop in `upstream-watch.yml` (unchanged) + a
  `.clast/upstream-baseline.json` listing its upstream packages, and add the repo to the routine.
