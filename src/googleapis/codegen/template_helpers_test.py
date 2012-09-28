#!/usr/bin/python2.6
#
# Copyright 2011 Google Inc. All Rights Reserved.
#
#  Licensed under the Apache License, Version 2.0 (the "License");
#  you may not use this file except in compliance with the License.
#  You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
#  Unless required by applicable law or agreed to in writing, software
#  distributed under the License is distributed on an "AS IS" BASIS,
#  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
#  See the License for the specific language governing permissions and
#  limitations under the License.

"""Tests for template_helpers."""

__author__ = 'aiuto@google.com (Tony Aiuto)'


import os

from google.apputils import basetest
# pylint: disable-msg=W0611
from googleapis.codegen import data_types
from googleapis.codegen import django_helpers
from googleapis.codegen import language_model
from googleapis.codegen import template_helpers
from googleapis.codegen import template_objects
from django import template as django_template  # pylint: disable-msg=C6203


class TemplateHelpersTest(basetest.TestCase):

  _TEST_DATA_DIR = os.path.join(os.path.dirname(__file__), 'testdata')

  def testExtractCommentPrefix(self):
    self.assertEquals('   *',
                      template_helpers._ExtractCommentPrefix('   * hello'))
    self.assertEquals('   *',
                      template_helpers._ExtractCommentPrefix('   *hello'))
    self.assertEquals('//',
                      template_helpers._ExtractCommentPrefix('// hello'))
    self.assertEquals('#',
                      template_helpers._ExtractCommentPrefix('# hello'))
    self.assertEquals('  #',
                      template_helpers._ExtractCommentPrefix('  # hello'))

  def testDivideIntoBlocks(self):
    test = """
      // block 1
      //
      // block 2a
      // block 2a

      // block 3
      // """
    blocks = []
    for block in template_helpers._DivideIntoBlocks(test.split('\n'),
                                                    '      //'):
      blocks.append(block)
    self.assertEquals(3, len(blocks))
    self.assertEquals(1, len(blocks[0]))
    self.assertEquals(2, len(blocks[1]))
    self.assertEquals(1, len(blocks[2]))

  def testCommentFragment(self):
    value = '123456789 ' * 15
    indent = 6
    # What we expect is that 9 of the sequences above will fit on the first
    # line, then we wrap. It's only 89 because the trailing space is trimmed.
    expected = value[:89] + '\n' + (' ' * indent) + ' * ' + value[90:-1]
    self.assertEquals(expected,
                      template_helpers.java_comment_fragment(value, indent))

  def testCommentBlockJavaDoc(self):
    alphabet = 'abcdefghijklmnopqrstuvwxyz'
    value = """
       * %s %s
       * %s %s %s
       * """ % (alphabet, alphabet, alphabet, alphabet, alphabet)
    expected = """
       * %s %s %s
       * %s %s""" % (alphabet, alphabet, alphabet, alphabet, alphabet)
    self.assertEquals(expected, template_helpers.block_comment(value))
    value = """
       // %s %s
       // %s %s %s
       // """ % (alphabet, alphabet, alphabet, alphabet, alphabet)
    expected = """
       // %s %s %s
       // %s %s""" % (alphabet, alphabet, alphabet, alphabet, alphabet)
    self.assertEquals(expected, template_helpers.block_comment(value))

  def testNoblanklines(self):
    self.assertEquals('a\nb', template_helpers.noblanklines('a\nb'))
    self.assertEquals('a\nb', template_helpers.noblanklines('a\nb\n\n'))
    self.assertEquals('a\nb', template_helpers.noblanklines('\na\n\nb\n'))

  def testCollapseNewLines(self):
    context = django_template.Context({})

    class NodesList(object):

      def __init__(self, ret):
        self._ret = ret

      def render(self, unused_context):  # pylint: disable-msg=C6409
        return self._ret

    collapse_node = template_helpers.CollapsedNewLinesNode(NodesList('ab'))
    self.assertEquals('ab', collapse_node.render(context))
    collapse_node = template_helpers.CollapsedNewLinesNode(NodesList('a\nb'))
    self.assertEquals('a\nb', collapse_node.render(context))
    collapse_node = template_helpers.CollapsedNewLinesNode(NodesList('a\n\nb'))
    self.assertEquals('a\n\nb', collapse_node.render(context))
    collapse_node = template_helpers.CollapsedNewLinesNode(
        NodesList('a\n\n\nb'))
    self.assertEquals('a\n\nb', collapse_node.render(context))
    collapse_node = template_helpers.CollapsedNewLinesNode(
        NodesList('a\n\n\n\nb'))
    self.assertEquals('a\n\nb', collapse_node.render(context))

  def testDocComments(self):
    def TryDocComment(language, input_text, expected):
      context = django_template.Context({})
      lang_node = template_helpers.LanguageNode(language)
      lang_node.render(context)
      context['_LINE_WIDTH'] = 50  # to make expected easier to read
      doc_comment_node = template_helpers.DocCommentNode(
          text=input_text, comment_type='doc')
      self.assertEquals(expected, doc_comment_node.render(context))

    alphabet = 'abcdefghijklmnopqrstuvwxyz'

    # single line java and php
    value = '%s' % alphabet
    expected = '/** %s */' % alphabet
    TryDocComment('java', value, expected)
    TryDocComment('php', value, expected)

    # multi line java and php
    value = '%s %s %s' % (alphabet, alphabet, alphabet)
    expected = '/**\n * %s\n * %s\n * %s\n */' % (alphabet, alphabet, alphabet)
    TryDocComment('java', value, expected)
    TryDocComment('php', value, expected)

    # single line csharp
    value = '%s' % alphabet
    expected = '/// <summary>%s</summary>' % alphabet
    TryDocComment('csharp', value, expected)

    # multi line csharp
    value = '%s %s %s' % (alphabet, alphabet, alphabet)
    expected = '/// <summary>%s\n/// %s\n/// %s</summary>' % (
        alphabet, alphabet, alphabet)
    TryDocComment('csharp', value, expected)

  def testCallTemplate(self):
    source = 'abc {% call_template _call_test foo bar qux api.xxx %} def'
    template = django_template.Template(source)
    rendered = template.render(django_template.Context({
        'template_dir': self._TEST_DATA_DIR,
        'api': {
            'xxx': 'yyy'
            },
        'bar': 'baz'
        }))
    self.assertEquals('abc 1baz1 2yyy2 3yyy3 def', rendered)

  def testCallTemplateRestoreVar(self):
    """Make sure variable stacking happens correctly on call_template."""
    source = 'abc {% call_template _call_test foo bar qux api.xxx %} {{foo}}'
    template = django_template.Template(source)
    rendered = template.render(django_template.Context({
        'template_dir': self._TEST_DATA_DIR,
        'api': {
            'xxx': 'yyy'
            },
        'bar': 'baz',
        'foo': 'OrigFoo'
        }))
    self.assertEquals('abc 1baz1 2yyy2 3yyy3 OrigFoo', rendered)

  def testParamList(self):
    source = """method({% parameter_list %}
          {% parameter %}int a{% end_parameter%}
          {% parameter %}
            {% if false %}
               The condition fails, so the entire parameter is empty.
            {% endif %}
          {% end_parameter %}
          {% parameter %}string b{% end_parameter %}
        {% end_parameter_list %})"""
    template = django_template.Template(source)
    rendered = template.render(django_template.Context({}))
    self.assertEquals('method(int a, string b)', rendered)

  def testImportWithoutManager(self):
    expected = """import hello_world
                  import abc"""
    source = '{% imports x %}\n' + expected + '\n{% endimports %}'
    template = django_template.Template(source)
    rendered = template.render(django_template.Context({'x': {}}))
    self.assertEquals(expected, rendered)

  def testLiteral(self):
    def TryTestLiteral(language, input_text, expected):
      context = django_template.Context({
          'foo': 'foo\nb"a$r',
          'bar': 'baz',
          'pattern': '\\d{4}-\\d{2}-\\d{2}'})
      lang_node = template_helpers.LanguageNode(language)
      lang_node.render(context)
      context['_LINE_WIDTH'] = 50  # to make expected easier to read
      node = template_helpers.LiteralStringNode(input_text)
      self.assertEquals(expected, node.render(context))

    TryTestLiteral('dart', ['foo', 'bar'], '"foo\\nb\\"a\\$rbaz"')
    TryTestLiteral('java', ['foo'], '"foo\\nb\\"a$r"')
    TryTestLiteral('java', ['bar'], '"baz"')
    TryTestLiteral('java', ['pattern'], '"\\\\d{4}-\\\\d{2}-\\\\d{2}"')
    TryTestLiteral('objc', ['foo'], '@"foo\\nb\\"a$r"')
    TryTestLiteral('php', ['foo', 'bar'], """'foo\nb"a$rbaz'""")

  def testCopyright(self):
    copyright_text = 'MY COPYRIGHT TEXT'
    expected_license_preamble = 'Licensed under the Apache License'
    template = django_template.Template(
        '{% language java %}{% copyright_block %}')
    context = django_template.Context({
        'template_dir': self._TEST_DATA_DIR,
        'api': {},
        })
    text_without_copyright = template.render(context)
    license_pos = text_without_copyright.find(expected_license_preamble)
    self.assertLess(3, license_pos)
    self.assertEquals(-1, text_without_copyright.find(copyright_text))
    context['api']['copyright'] = copyright_text
    text_with_copyright = template.render(context)
    license_pos_with_copyright = text_with_copyright.find(
        expected_license_preamble)
    self.assertLess(license_pos, license_pos_with_copyright)
    copyright_pos = text_with_copyright.find(copyright_text)
    self.assertEquals(license_pos, copyright_pos)

  def testGetArgFromToken(self):
    # This tests indirectly by going through a few tags known to call
    # _GetArgFromToken. That expedient avoids having to create a token stream
    # at a low level.

    # try a good one
    template = django_template.Template('{% camel_case foo %}')
    context = django_template.Context({'foo': 'hello_world'})
    self.assertEquals('HelloWorld', template.render(context))

    # Missing the arg
    for tag in ['language', 'comment_if', 'doc_comment_if']:
      try:
        template = django_template.Template('{%% %s %%}' % tag)
        self.fail('TemplateSyntaxError not raised')
      except django_template.TemplateSyntaxError as e:
        self.assertEquals('tag requires a single argument: %s' % tag, str(e))

  def testDataContextNode(self):
    # This happens to test the "value_of" tag as well.
    lang_model = language_model.LanguageModel('|')
    foo_def_dict = {
        'className': 'Foo',
        'type': 'string',
        }
    prototype = data_types.DataType(
        foo_def_dict, None, language_model=lang_model)
    dv = template_objects.DataValue('four', prototype)

    source = '{% value_of data %}'
    template = django_template.Template(source)

    context = django_template.Context({'data': dv})
    self.assertEquals('"four"', template.render(context))

    context = django_template.Context({'data': 'foo'})
    self.assertRaises(
        django_template.TemplateSyntaxError, template.render, context)

    bar_def_dict = {
        'className': 'Foo',
        'type': 'parrot',
        }
    prototype = data_types.DataType(
        bar_def_dict, None, language_model=lang_model)
    dv = template_objects.DataValue('fred', prototype)

    context = django_template.Context({'data': dv})
    self.assertRaises(
        django_template.TemplateSyntaxError, template.render, context)

  def testCache(self):
    loader = template_helpers.CachingTemplateLoader()
    template_dir = os.path.join(self._TEST_DATA_DIR, 'templates')
    test_path = os.path.join(template_dir, 'java/1.0dev/test.tmpl')
    stable_path = os.path.join(template_dir, 'java/1.0/test.tmpl')
    loader.GetTemplate(test_path, template_dir)
    loader.GetTemplate(stable_path, template_dir)
    self.assertTrue(stable_path in loader._cache)
    self.assertFalse(test_path in loader._cache)


if __name__ == '__main__':
  basetest.main()
