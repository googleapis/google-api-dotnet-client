# How to become a contributor and submit patches #

## Contributor License Agreements ##

We'd love to accept your code patches! However, before we can take them, we have to jump a couple of legal hurdles.

Please fill out either the individual or corporate Contributor License Agreement.

  * If you are an individual writing original source code and you're sure you own the intellectual property, then you'll need to sign an [individual CLA](http://code.google.com/legal/individual-cla-v1.0.html).
  * If you work for a company that wants to allow you to contribute your work to this client library, then you'll need to sign a [corporate CLA](http://code.google.com/legal/corporate-cla-v1.0.html).

Follow either of the two links above to access the appropriate CLA and instructions for how to sign and return it. Once we receive it, we'll add you to the official list of contributors and be able to accept your patches.

## Submitting Patches ##

  1. Sign a Contributor License Agreement (see above).
  1. Join our [discussion group](http://groups.google.com/group/google-api-dotnet-client)
  1. Optional: create a [personal Mercurial server-side clone](http://code.google.com/p/support/wiki/MercurialFAQ#Why_should_I_create_a_server-side_clone?) for the bug fix.
  1. Prepare a Mercurial changeset in the [Issue Tracker](http://code.google.com/p/google-api-dotnet-client/issues/list). Create a new Issue if there's isn't one already.  Coordinate with the team member assigned for that Issue to better coordinate the efforts and make sure we're not duplicating work.  This team member will also be responsible for pulling in your changeset into the official repository at the end of the process (unless you are an official contributor).
  1. Sign in to http://codereview.appspot.com and create a new "Issue".  Make sure to use the [upload.py](http://codereview.appspot.com/static/upload.py) tool. Specify the "Issue" number from this client library project Issue Tracker.  Unfortunately, the term "Issue" is confusingly used to mean two different things between the code review tool and the Issue Tracker.
  1. If you are not an official Contributor, after completing the code review process and receiving approval, a Contribtor will pull in your changeset into the official repository.

# Setting up Development Environment #

## Prerequisites ##

  1. Install [Mercurial (Hg)](http://mercurial.selenic.com/)
    * Optional tutorial at [hginit.com](http://hginit.com)
    * On a **Windows** machine you can download and install Tortoise Hg
  1. Install your IDE:
    * On a **Linux** machine, install [MonoDevelop](http://monodevelop.com/)
    * On a **Windows** machine, install [Visual Studio](http://www.microsoft.com/visualstudio/eng/products/visual-studio-overview)

**Set up the hgrc file:**

Set up your _~/.hgrc_ file (_%USERPROFILE%\mercurial.ini_ on **Windows**) with your username and password from https://code.google.com/hosting/settings as follows

```
[ui]
username = Your Name <yourname@domain.com>

[auth]
google-api-dotnet-client.prefix = https://code.google.com/p/google-api-dotnet-client/
google-api-dotnet-client.username = your_username
google-api-dotnet-client.password = your_password
samples-google-api-dotnet-client.prefix = https://code.google.com/p/google-api-dotnet-client.samples/
samples-google-api-dotnet-client.username = your_username
samples-google-api-dotnet-client.password = your_password

[extensions]
purge =
```

## Check out the code ##

There are two Mercurial repositories:
  * "default" repository has the library.  The "default" branch has the latest unreleased code under development.  Additionally, each release has its own branch, e.g. "1.5" branch for the 1.5.X-beta releases.
  * "samples" repository has all of the samples under the "default" branch.

To check out the "default" library repository in the development "default" branch:

```
cd <rootDirectory>
hg clone https://code.google.com/p/google-api-dotnet-client/ google-api-dotnet-client/default
```

If you need to switch to an alternative branch (e.g. 1.12):

```
hg update 1.12
```

If you need to switch back to the development branch:

```
hg update default
```

When you need to "pull" in the latest changes from the central server and "update" your local workspace to the latest changeset:

```
hg pull --update
```

If you need to check out the "samples" repository:

```
cd <rootDirectory>
hg clone https://code.google.com/p/google-api-dotnet-client.samples/ google-api-dotnet-client/samples
```

# Code Review Process #



**Prerequisites:**



  1. Download [upload.py](http://codereview.appspot.com/static/upload.py) and optionally add it to your PATH (NOTICE that upload.py requires Python 2.x and it doesn't work on Python 3.x)

The first time you run the upload.py script, it will ask you for an [application-specific password](http://support.google.com/accounts/bin/answer.py?hl=en&answer=185833):

```

Email (login for uploading to codereview.appspot.com):your_email_address@yourdomain.com
Password for your_email_address@yourdomain.com: <enter your application-specific password>

```



  1. **Windows** users, please notice: to run the _upload.py_ (or any other Python script files), you should associate _.py_ files to Python with the following commands:

```

ftype PythonFileType=c:\python_26_amd64\files\python.exe "%0" %*
assoc .py=PythonFileType

```



## Starting the code review ##

After making changes, change to the root directory of the hg clone, and create a new issue on codereview.appspot.com:

```

upload.py --base_url=https://google-api-dotnet-client.googlecode.com/hg/ --send_mail -r reviewer@somedomain --cc ...
or
upload.py --base_url=https://google-api-dotnet-client.samples.googlecode.com/hg/ --send_mail -r reviewer@somedomain --cc ...

```



After making more changes, you will want to upload a new patch (assume the issue # is 123456):

```

upload.py -i 123456

```


## Code reviewer ##

As a code reviewer, you will likely want to import their patch into your hg clone.  The trick is to find the "Download raw patch set" at the top right of the patch specification.  For example:

```

hg import --no-commit https://codereview.appspot.com/download/issue123456_10000.diff

```

(For issue # 123456, revision # 10000)

**Windows** users: notice that hg import may fail without reasonable reason. It happens because the diff file is in Unix format. You should convert the file using a converter like  [Unix2Dos](http://waterlan.home.xs4all.nl/dos2unix.html).

Be careful with the following command: it literally erases all of your local changes.  This is primarily useful when you want to get rid of an imported patch:

```

hg revert -a && hg purge

```



The general rule of thumb is that code cannot be committed into the Hg server until the code reviewer is satisfied that your code is ready.  At that point, the convention is to reply with the message "LGTM" (Looks Good To Me).



## Committing the code ##



If there are any new changes in the central Mercurial server that you have not yet "pulled" in to your local workspace, committing now would unintentionally cause a new "branch"  or "head" to be created.  That would happen because the "parent changeset" for your commit would not be the latest changeset in the server.  Hence, you would get an error message when trying to do "hg push" about created multiple "heads".  The only way to resolve it would be to "merge" the heads (details below).  To avoid this complexity, it is important to "pull" in the latest changes from the central server and "update" your local workspace to the latest changeset:



```

hg pull --update

```



To commit the code **locally** (assuming you are fixing/implementing [Issue 123](https://code.google.com/p/google-api-dotnet-client/issues/detail?id=123)):

```

hg commit

```



Enter a message like this:



```

Issue 123: NullPointerException when passing null to processFoo()
http://codereview.appspot.com/123456/

```



First, before the colon and description, should be the project and the issue number _if_ this is a fix to a problem on http://code.google.com/p/google-api-dotnet-client/issues. In addition, if this is a change for a particular branch, include the branch number as well.


The link to the codereview is important because otherwise there's no convenient way to figure out the code review associated with a commit, which can potentially be really useful in the future if we ever wanted to know what the discussion was at the time of a particular commit.


But you're not done yet!  You still need push the change to the server:

```

hg push

```



If it asks for your password, use the password from https://code.google.com/hosting/settings.



If during `hg push` you get an error message about creating a new head (perhaps you forgot to run `hg pull --update`), you probably want to merge with the latest changes:

```

hg pull

hg merge

hg commit

hg push

```



If you get an error message "HTTP Error 403: Forbidden" that means you are not on the list at https://code.google.com/p/google-api-dotnet-client/people/list .  Ask one of the Owners to add you to the list as a "Committer".



**Final step:** make sure to "close" the issue on https://codereview.appspot.com/ by clicking on the "X" on the top left preceding the word "Issue".