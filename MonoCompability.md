In order to use the Google .NET client library with mono, some changes might be required. If you want to use any of the features listed below, or receive one of the following error messages just follow the instructions to fix the problem.

_Make these changes at your own risk! They are only provided to temporarily solve these problems. Once a official version is released, or the problem no longer persists, you should stop using these changes._

## OAuth2 - Install a System.ServiceModel.Web.dll (if using mono 2.4) ##
If you are using an old version of mono which does not have this .dll included, you can install a package including this .dll separately, e.g. this one:
  * [mono-wcf-2.8.2](ftp://rpmfind.net/linux/sourceforge/o/project/ou/outmodedbonsai/Ximian%20Mono/Fedora%20updates/mono%202.8.2%20for%20fc14/mono-wcf-2.8.2-1.fc14lh.x86_64.rpm)

If you are running Ubuntu, you can install it by running the command below:
```
sudo alien -i mono-wcf-2.8.2-1.fc14lh.x86_64.rpm
```

The .dll is required by the DotNetOpenAuth library, which is used for the OAuth2 authentication used by most Google services.

## Invalid Certificate Error ##
You might have to manually update the mono certificate store if you get an "Invalid Certificate"-error when running the samples. You can do so by running the command:
```
mozroots --import --sync
```
(Run this as a normal user, not as a super user!)