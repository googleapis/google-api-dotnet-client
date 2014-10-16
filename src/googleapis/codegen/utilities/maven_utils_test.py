#!/usr/bin/python2.7


from google.apputils import basetest
from googleapis.codegen import java_generator
from googleapis.codegen.utilities import maven_utils


class MavenUtilsTest(basetest.TestCase):

  def testGetMavenArtifactId(self):
    args = [
        ({'api_name': 'adsense'}, 'google-api-services-adsense'),
        ({'api_name': 'adsense', 'owner_domain': 'snorg.com'}, 'adsense'),
        ({'api_name': 'adsense', 'owner_domain': 'snorg.com',
          'package_path': 'snorg.foobar'},
         'snorg-foobar-adsense'),
        ({'api_name': 'admin', 'package_path': 'admin',
          'canonical_name': 'reports'},
         'google-api-services-admin-reports'),
        ]
    for kwargs, artifact_id in args:
      self.assertEquals(artifact_id, maven_utils.GetMavenArtifactId(**kwargs))

  def testMavenArtifactIdAndModulePath(self):

    def TestApi(api_def):
      gen = java_generator.BaseJavaGenerator(api_def,
                                             options={'google_api': True})
      gen.AnnotateApiForLanguage(gen.api)
      api = gen.api

      # drop the leading com
      expected = '-'.join(api.module.path.split('/')[1:])
      actual = maven_utils.GetMavenArtifactId(
          api_def['name'],
          package_path=api_def.get('packagePath'),
          canonical_name=api_def.get('canonicalName'),
          owner_domain=api_def['ownerDomain'])
      self.assertEquals(expected, actual)
    TestApi({'name': 'admin',
             'version': 'directory_v1',
             'canonicalName': 'directory',
             'packagePath': 'admin',
             'ownerDomain': 'google.com'})
    TestApi({'name': 'identitytoolkit',
             'version': 'v1',
             'canonicalName': 'Identity Toolkit',
             'ownerDomain': 'google.com'})
    TestApi({'name': 'identitytoolkit',
             'version': 'v1',
             'packagePath': 'zomby',
             'canonicalName': 'Identity Toolkit',
             'ownerDomain': 'google.com'})

  def testGetMavenGroupId(self):
    self.assertEquals('com.foo.bar', maven_utils.GetMavenGroupId('bar.foo.com'))
    self.assertEquals('com.google.apis',
                      maven_utils.GetMavenGroupId('google.com'))

  def testGetMavenVersion(self):
    google_api = {'name': 'api',
                  'version': 'v1',
                  'revision': 3,
                  'ownerDomain': 'google.com'}
    lv = '1.5'
    self.assertEquals('v1-rev3-1.5',
                      maven_utils.GetMavenVersion(google_api, lv))
    endpoints_api = {'name': 'api',
                     'version': 'v1',
                     'ownerDomain': 'bestbuy.com'}
    self.assertEquals('v1-1.5-SNAPSHOT',
                      maven_utils.GetMavenVersion(endpoints_api, lv))


if __name__ == '__main__':
  basetest.main()
