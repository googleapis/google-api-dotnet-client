

# Introduction #

When working on the .NET client library, it is important that all developers adhere to the same coding standards. This document shows the most important rules you should follow in order to ease the review process.

For all those points not covered within this document you should follow the Microsoft C# coding guidelines, which can be found at the link below:

> [Design Guidelines for Class Library Developers](http://msdn.microsoft.com/en-us/library/czefa0ke(vs.71).aspx)

Another helpful introduction on coding standards can also be found at:

> [Coding Guidelines](http://blogs.msdn.com/b/brada/archive/2005/01/26/361363.aspx)

# IDE settings #

You should change these values in your IDE to the following values:
  * **Tab width**: 4 spaces
  * **Tab type**: spaces (not tabs!)
  * **Maximum line length**: 120 (excluding using statements)

# Comments #
  * All public classes/interfaces/properties/methods require XML comments
  * All comments should end in a period, including XML comments
  * All normal comments should follow this style:
```
// Comment here.
```

# File Layout #

## Header ##
```
/*
Copyright 20__ Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
```

## Regions ##

Regions should be used to organize logically similar blocks of code. Newlines should be inserted after the #region and before the #endregion tags:

```

#region

Some code here

#endregion

```

## Usings ##
Organize usings in alphabetical order, in 3 groups, .Net runtime, 3rd party libraries, this project. Each group sorted alphabetically and separated with a new line.  Example:
```
using System.a
using System.b

using Log4Net.A
using Log4Net.B
using NUnit.A

using Google.Api
```

## Blocks ##
Open braces should always be at the beginning of the line after the statement that begins the block. Contents of the brace should be indented by 4 spaces. For example:
```
if (someExpression)
{
   DoSomething();
}
else
{
   DoSomethingElse();
}
```

“case” statements should be indented from the switch statement like this:
```
switch (someExpression) 
{

   case 0:
      DoSomething();
      break;

   case 1:
      DoSomethingElse();
      break;

   case 2:
      // With a variable.
      {
         int n = 1;
         DoAnotherThing(n);
      }
      break;

   case 3:
      // Without a variable.
      DoAnotherThing(n);
      DoAnotherThing(n);      
      break;
}
```

## Braces ##
Braces are <b>never</b> considered optional. Even for single statement blocks, you should always use braces. This increases code readability and maintainability:

```
  if (someExpression)
  {
    return true;
  }
```

## Properties ##
When no logic is required automatic properties are preferred. These should be on one line. e.g.
```
public string Name { get; set; }
public string EmailAddress { get; private set; }
```
If logic or logging is required use the following form
```
private string name;

public string Name 
{
   get
   {
     // multiple line logic
     name += " ";
     return name;
   }
   set { this.name = value; }
}

private string emailAddress;

public string EmailAddress
{
   get { return emailAddress; } // Single line logic.
   set
   {
        // multiple line logic
        this.emailAddress = value;
        DoSomething();
   }
}
```

## Attributes ##

Attributes should never have () unless an argument is given:

```
  [Test]
  public void SomethingTest() { ... }

  [SomeAttribute(true)]
  public void SomeMethod() { ... }
```

## Usage of the <b>this</b> keyword ##

The <b>this</b> keyword should only be used in front of member variables:

```
  SomeMethodCall();
  this.someMember = 2;
```

The <b>this</b> keyword should be ommited where it is legal to, unless it is likely to cause confusion
```
public class Foo
  private string bar;
  private int calculated;

  public string Bar { get { return bar; } } // Not this.bar .

  public Foo(string bar)
  {
      this.bar = bar; // this keyword is required.
      this.calculated = bar.length; // this keyword is acceptable.
  }

```

## Resharper Settings ##
If you are using resharper, this coding standard file might come in handy. You can import the settings by clicking on the "Import" button under "Codestyle Sharing"

```
<CodeStyleSettings>
  <CSharp>
    <FormatSettings>
      <EMPTY_BLOCK_STYLE>TOGETHER_SAME_LINE</EMPTY_BLOCK_STYLE>
      <FORCE_FIXED_BRACES_STYLE>ALWAYS_ADD</FORCE_FIXED_BRACES_STYLE>
      <FORCE_FOR_BRACES_STYLE>ALWAYS_ADD</FORCE_FOR_BRACES_STYLE>
      <FORCE_FOREACH_BRACES_STYLE>ALWAYS_ADD</FORCE_FOREACH_BRACES_STYLE>
      <FORCE_IFELSE_BRACES_STYLE>ALWAYS_ADD</FORCE_IFELSE_BRACES_STYLE>
      <FORCE_USING_BRACES_STYLE>ALWAYS_ADD</FORCE_USING_BRACES_STYLE>
      <FORCE_WHILE_BRACES_STYLE>ALWAYS_ADD</FORCE_WHILE_BRACES_STYLE>
      <KEEP_USER_LINEBREAKS>False</KEEP_USER_LINEBREAKS>
      <MODIFIERS_ORDER IsNull="False">
        <Item>public</Item>
        <Item>protected</Item>
        <Item>internal</Item>
        <Item>private</Item>
        <Item>new</Item>
        <Item>abstract</Item>
        <Item>virtual</Item>
        <Item>override</Item>
        <Item>sealed</Item>
        <Item>static</Item>
        <Item>readonly</Item>
        <Item>extern</Item>
        <Item>unsafe</Item>
        <Item>volatile</Item>
      </MODIFIERS_ORDER>
      <SIMPLE_EMBEDDED_STATEMENT_STYLE>LINE_BREAK</SIMPLE_EMBEDDED_STATEMENT_STYLE>
      <SPACE_AROUND_MULTIPLICATIVE_OP>True</SPACE_AROUND_MULTIPLICATIVE_OP>
      <SPACE_BEFORE_TYPEOF_PARENTHESES>False</SPACE_BEFORE_TYPEOF_PARENTHESES>
      <SPACE_WITHIN_SINGLE_LINE_ARRAY_INITIALIZER_BRACES>True</SPACE_WITHIN_SINGLE_LINE_ARRAY_INITIALIZER_BRACES>
      <WRAP_AFTER_INVOCATION_LPAR>True</WRAP_AFTER_INVOCATION_LPAR>
      <WRAP_PARAMETERS_STYLE>CHOP_IF_LONG</WRAP_PARAMETERS_STYLE>
    </FormatSettings>
    <UsingsSettings />
    <Naming2>
      <EventHandlerPatternLong>$object$_On$event$</EventHandlerPatternLong>
      <EventHandlerPatternShort>$event$Handler</EventHandlerPatternShort>
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="TypesAndNamespaces" />
      <PredefinedRule Inspect="True" Prefix="I" Suffix="" Style="AaBb" ElementKind="Interfaces" />
      <PredefinedRule Inspect="True" Prefix="T" Suffix="" Style="AaBb" ElementKind="TypeParameters" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="MethodPropertyEvent" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="Locals" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="LocalConstants" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="Parameters" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PublicFields" />
      <PredefinedRule Inspect="True" Prefix="_" Suffix="" Style="aaBb" ElementKind="PrivateInstanceFields" />
      <PredefinedRule Inspect="True" Prefix="_" Suffix="" Style="aaBb" ElementKind="PrivateStaticFields" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="Constants" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PrivateConstants" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="StaticReadonly" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PrivateStaticReadonly" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="EnumMember" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="Other" />
    </Naming2>
  </CSharp>
  <VB>
    <FormatSettings>
      <WRAP_ARGUMENTS_STYLE>CHOP_IF_LONG</WRAP_ARGUMENTS_STYLE>
    </FormatSettings>
    <ImportsSettings />
    <Naming2>
      <EventHandlerPatternLong>$object$_On$event$</EventHandlerPatternLong>
      <EventHandlerPatternShort>$event$Handler</EventHandlerPatternShort>
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="TypesAndNamespaces" />
      <PredefinedRule Inspect="True" Prefix="I" Suffix="" Style="AaBb" ElementKind="Interfaces" />
      <PredefinedRule Inspect="True" Prefix="T" Suffix="" Style="AaBb" ElementKind="TypeParameters" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="MethodPropertyEvent" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="Locals" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="LocalConstants" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="Parameters" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PublicFields" />
      <PredefinedRule Inspect="True" Prefix="_" Suffix="" Style="aaBb" ElementKind="PrivateInstanceFields" />
      <PredefinedRule Inspect="True" Prefix="_" Suffix="" Style="aaBb" ElementKind="PrivateStaticFields" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="Constants" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PrivateConstants" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="StaticReadonly" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PrivateStaticReadonly" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="EnumMember" />
      <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="Other" />
    </Naming2>
  </VB>
  <Web>
    <Naming2 />
  </Web>
  <Xaml>
    <Naming2>
      <UserRule Name="XAML_FIELD" Inspect="True" Prefix="_" Suffix="" Style="aaBb" />
      <UserRule Name="NAMESPACE_ALIAS" Inspect="True" Prefix="" Suffix="" Style="AaBb" />
      <UserRule Name="XAML_RESOURCE" Inspect="True" Prefix="" Suffix="" Style="AaBb" />
    </Naming2>
  </Xaml>
  <XML>
    <FormatSettings />
  </XML>
  <FileHeader><![CDATA[Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
  
   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
]]></FileHeader>
  <GenerateMemberBody />
  <Naming2>
    <EventHandlerPatternLong>$object$_On$event$</EventHandlerPatternLong>
    <EventHandlerPatternShort>$event$Handler</EventHandlerPatternShort>
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="Locals" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="TypesAndNamespaces" />
    <PredefinedRule Inspect="True" Prefix="I" Suffix="" Style="AaBb" ElementKind="Interfaces" />
    <PredefinedRule Inspect="True" Prefix="T" Suffix="" Style="AaBb" ElementKind="TypeParameters" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="MethodPropertyEvent" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="LocalConstants" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="aaBb" ElementKind="Parameters" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PublicFields" />
    <PredefinedRule Inspect="True" Prefix="_" Suffix="" Style="aaBb" ElementKind="PrivateInstanceFields">
      <ExtraRule Prefix="" Suffix="" Style="aaBb" />
    </PredefinedRule>
    <PredefinedRule Inspect="True" Prefix="_" Suffix="" Style="aaBb" ElementKind="PrivateStaticFields" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="Constants" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PrivateConstants" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="StaticReadonly" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="PrivateStaticReadonly" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="EnumMember" />
    <PredefinedRule Inspect="True" Prefix="" Suffix="" Style="AaBb" ElementKind="Other" />
    <Abbreviation Text="URI" />
  </Naming2>
</CodeStyleSettings>
```