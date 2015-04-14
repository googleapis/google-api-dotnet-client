# Introduction #

Version control is important to any software project, these rules (not guidelines) must be followed on the project.  The aim is to keep them as simple and as fluid as possible so that it is not an impedance to developer new software.

## Details ##

We currently have one default branch.  The default branch represents the latest snapshot of the latest working version of the code.

  * Code is never developed on the default branch, instead create an issue in the Issue Tracker then:
    * If you are a committer you can perform this on the default repository.  Create a new branch using the command `hg branch issue_[ID]` where ID is the issue ID.
  * If you are not a committer to the main project, you need to first create a clone here: http://code.google.com/p/google-api-dotnet-client/source/createClone, then create a branch using the command `hg branch issue_[ID]`
  * Code is never merged into the default branch unless it has been [CodeReview](CodeReview.md)ed.
  * A contributor must merge the code into the default branch

## Standard work flow ##
For those not used to working with Mercurial and codereview.appspot.com here is a standard work flow to use as a cheatsheet. These are guildlines not rules.

**First time only**
```
$ mkdir exampleDirectoryName
$ cd exampleDirectoryName
$ hg clone https://youemail%40yourdomain.com@code.google.com/p/google-api-dotnet-client/
```

**Make sure you have the latest version**
```
$ hg pull
$ hg update
```

**Raise an issue in issue tracker (if one not already present)**

http://code.google.com/p/google-api-dotnet-client/issues/list

**Create a feature branch**
```
$ hg checkout default
$ hg branch issue_NUMBER_Descriptive_Text
```

**Make your change**
```
Hack Hack Hack
Run unit tests
$ hg commit -m "Be careful of your commit comments they will be public"
```

**Send you code out to review**
```
$ upload.py --rev default
```
Go to the codereview you have just created (link in output of last statment) add a reviewer and click publish.

**Correct the silly mistakes the code reviewer pointed out**
```
Hack Hack Hack
Run unit tests
$ hg commit -m "Fix potential bug reviewer pointed"
$ upload.py --rev default -i CODE-REVIEW-ID
```

**Got LGTM - merge close branch, merge with default**
```
$ hg commit -m "Closing Branch" --close-branch
$ hg checkout default
$ hg pull
$ hg update
$ hg merge issue_NUMBER_Descriptive_Text
$ hg commit -m "Merge issue_NUMBER_Description as per codereview https://codereview.appspot.com/CODE_REVIEW_ID/"
```

**Push your revisions to the central code server**
```
$ hg push
```

## Versioning of the API ##

There is a very strong chance that the Discovery document will change, **if we decide** to move to a newer version for the Discovery API, it is likely to be a breaking change.  This will be developed under a new branch until it is ready to be made the active version and merged on to the default branch.

A new branch will be made for the previous of the client code named v[XYZ](XYZ.md).  This puts that version in to maintenance mode (although it still might be the main active version), like with the default branch, all the same rules for commiting code apply.

To create a branch from a specific API branch, first change your working set to the version of the API you are fixing, for example `hg update -C v2` will switch to the v2 branch.  Now create your branch for your issue by performing an `hg branch issues_id`