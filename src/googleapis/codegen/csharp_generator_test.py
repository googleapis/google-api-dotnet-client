#!/usr/bin/python2.7
"""Tests for csharp generator."""

from google.apputils import basetest
from googleapis.codegen import csharp_generator


class NestedClassNameTest(basetest.TestCase):

  NESTED_API = {
      'name': 'nestor',
      'version': 'v1',
      'resources': {},
      'schemas': {
          'A': {
              'id': 'A',
              'type': 'object',
              'properties': {
                  'B': {
                      'id': 'B',
                      'type': 'object',
                      'properties': {
                          'count': {
                              'type': 'integer',
                              'format': 'int32'
                              }
                          }
                      }
                  }
              },
          'C': {
              'id': 'C',
              'type': 'array',
              'items': {
                  '$ref': 'A'
                  }
              },
          'D': {
              'id': 'D',
              'type': 'array',
              'items': {
                  'type': 'object',
                  'properties': {
                      'foo': {
                          'type': 'string'
                          }
                      }
                  }
              },
          'E': {
              'id': 'E',
              'type': 'object',
              'properties': {
                  'F': {
                      'type': 'array',
                      'items': {
                          'type': 'object',
                          'properties': {
                              'aproperty': {
                                  'type': 'string'
                                  }
                              }
                          }
                      }
                  }
              }
          }
      }

  COMPUTE_EXTRACT = {
      'name': 'computeextract',
      'version': 'v1',
      'resources': {},
      'schemas': {
          'MachineType': {
              'id': 'MachineType',
              'type': 'object',
              'properties': {
                  'ephemeralDisks': {
                      'type': 'array',
                      'items': {
                          'type': 'object',
                          'properties': {
                              'diskGb': {
                                  'type': 'integer',
                                  'format': 'int32'
                                  }
                              }
                          }
                      }
                  }
              }
          }
      }

  FREEBASE_EXTRACT = {
      'name': 'freebase',
      'version': 'v1',
      'resources': {},
      'schemas': {
          'TopicStatslinkcount': {
              'id': 'TopicStatslinkcount',
              'type': 'object',
              'properties': {
                  'type': {
                      'type': 'string',
                      'default': 'custom'
                      },
                  'values': {
                      'type': 'array',
                      'items': {
                          'type': 'object',
                          'properties': {
                              'count': {
                                  'type': 'integer',
                                  'format': 'int32'
                                  },
                              'id': {
                                  'type': 'string'
                                  },
                              'values': {
                                  'type': 'array',
                                  'items': {
                                      'type': 'object',
                                      'properties': {
                                          'count': {
                                              'type': 'integer',
                                              'format': 'int32'
                                              },
                                          'id': {
                                              'type': 'string'
                                              },
                                          'values': {
                                              'type': 'array',
                                              'items': {
                                                  'type': 'object',
                                                  'properties': {
                                                      'count': {
                                                          'type': 'integer',
                                                          'format': 'int32'
                                                          },
                                                      'id': {
                                                          'type': 'string'
                                                          }
                                                      }
                                                  }
                                              }
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  }
              }
          }
      }

  def testNestedClassName(self):
    gen = csharp_generator.CSharpGenerator(discovery=self.NESTED_API)
    gen.AnnotateApiForLanguage(gen.api)
    self.assertEquals({'A', 'A.B', 'C', 'D', 'DItems', 'E', 'E.F'},
                      set(gen.api._schemas))
    b_schema = gen.api._schemas['A.B']
    c_schema = gen.api._schemas['C']
    self.assertEquals('A.B', b_schema.packageRelativeClassName)
    # TODO(user): This is the current behavior.  We could change it for
    # csharp by annotating schemas and setting codeType to
    # packageRelativeClassName, but that will uncover other bugs -- due to the
    # many ways of getting at a class name (codeType, code_type, safeCodeType,
    # safe_code_type, class_name, className, safe...) there is inconsistency in
    # the code base, and we'll end up prepending parent names in some cases more
    # than once.
    self.assertEquals('B', b_schema.code_type)
    self.assertEquals('System.Collections.Generic.IList<A>', c_schema.code_type)
    d_schema = gen.api._schemas['D']
    self.assertEquals('System.Collections.Generic.IList<DItems>',
                      d_schema.code_type)

  def testAbsurdlyNestedButRealClassNames(self):
    gen = csharp_generator.CSharpGenerator(discovery=self.FREEBASE_EXTRACT)
    gen.AnnotateApiForLanguage(gen.api)
    schema_names = sorted(s.class_name.split('.')[-1]
                          for s in gen.api._schemas.itervalues())
    expected = sorted(['TopicStatslinkcount',
                       'ValuesData',  # nested 1
                       'ValuesDataSchema',  # nested 2
                       'ValuesData',  # nested 3
                      ])
    self.assertEquals(expected, schema_names)

  def testNestedArray(self):
    gen = csharp_generator.CSharpGenerator(discovery=self.COMPUTE_EXTRACT)
    gen.AnnotateApiForLanguage(gen.api)
    self.assertEquals({'MachineType', 'MachineType.ephemeralDisks'},
                      set(gen.api._schemas))
    # The array type in this case is not available in the schema list; we have
    # to spelunk into the properties to get at it.
    machine_type_schema = gen.api._schemas['MachineType']
    # While properties in discovery are dictionaries, for some reason
    # the dictionary is overridden and replaced by a dict in the object model.
    disk_array = [p for p in machine_type_schema['properties']
                  if p['wireName'] == 'ephemeralDisks'][0]
    self.assertEquals(
        'System.Collections.Generic.IList<MachineType.EphemeralDisksData>',
        disk_array.code_type)
    ephemeral_disk_schema = gen.api._schemas['MachineType.ephemeralDisks']
    self.assertEquals('EphemeralDisksData', ephemeral_disk_schema.safeClassName)


class PackagePathTest(basetest.TestCase):

  def testPackagePath(self):
    discovery = {
        'name': 'foo',
        'version': 'v1',
        'packagePath': 'nougat',
        'schemas': {},
        'resources': {},
        }
    gen = csharp_generator.CSharpGenerator(discovery)
    gen.AnnotateApiForLanguage(gen.api)
    api = gen.api
    self.assertEquals('Google.Apis.Nougat.Foo.v1', api.module.name)
    self.assertEquals('Google.Apis.Nougat.Foo.v1.Data', api.model_module.name)


class VersionWithDashTest(basetest.TestCase):

  def testVersionWithDash(self):
    discovery = {
        'name': 'foo',
        'version': 'v1-dash',
        'schemas': {},
        'resources': {},
        }
    gen = csharp_generator.CSharpGenerator(discovery)
    gen.AnnotateApiForLanguage(gen.api)
    api = gen.api
    self.assertEquals('Google.Apis.Foo.v1dash', api.module.name)
    self.assertEquals('Google.Apis.Foo.v1dash.Data', api.model_module.name)


class MemberNameTest(basetest.TestCase):

  def testMemberNameConflictWithParentClass(self):
    api = {
        'name': 'groups',
        'version': 'v1',
        'schemas': {
            'Groups': {
                'id': 'Groups',
                'type': 'object',
                'properties': {
                    'groups': {
                        'type': 'string'
                        }
                    }
                }
            }
        }
    gen = csharp_generator.CSharpGenerator(discovery=api)
    gen.AnnotateApiForLanguage(gen.api)
    groups_schema = gen.api._schemas['Groups']
    groups_prop = groups_schema['properties'][0]
    self.assertEquals('GroupsValue', groups_prop.memberName)

  def testMemberNameConflictWithParentClassWithUnderscores(self):
    api = {
        'name': 'groups',
        'version': 'v1',
        'schemas': {
            'GroupsThing': {
                'id': 'groups_thing',
                'type': 'object',
                'properties': {
                    'groups_thing': {
                        'type': 'string'
                        }
                    }
                }
            }
        }
    gen = csharp_generator.CSharpGenerator(discovery=api)
    gen.AnnotateApiForLanguage(gen.api)
    groups_schema = gen.api._schemas['GroupsThing']
    groups_prop = groups_schema['properties'][0]
    self.assertEquals('GroupsThingValue', groups_prop.memberName)


class MapTest(basetest.TestCase):

  def testMapNameIsConsistent(self):
    api = {
        'name': 'discovery',
        'version': 'v1',
        'schemas': {
            'RestDescription': {
                'id': 'RestDescription',
                'type': 'object',
                'properties': {
                    'auth': {
                        'type': 'object',
                        'properties': {
                            'oauth2': {
                                'type': 'object',
                                'properties': {
                                    'scopes': {
                                        'type': 'object',
                                        'additionalProperties': {
                                            'type': 'object',
                                            'properties': {
                                                'description': {
                                                    'type': 'string',
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    gen = csharp_generator.CSharpGenerator(discovery=api)
    gen.AnnotateApiForLanguage(gen.api)
    schemas = gen.api._schemas
    oauth2_schema = schemas['RestDescription.auth.oauth2']
    scopes_schema = schemas['RestDescription.auth.oauth2.scopesElement']
    child_schema = oauth2_schema.children[0]
    self.assertEquals(scopes_schema, child_schema)
    self.assertEquals('ScopesDataElement', scopes_schema.safeClassName)


if __name__ == '__main__':
  basetest.main()
