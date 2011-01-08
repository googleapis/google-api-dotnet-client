// /*
// Copyright 2010 Google Inc
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// */

using System;
using System.Collections.Generic;

namespace Google.Apis
{
    public interface ISchemaProperty
    {
        string Name{get;}
        string Type{get;}
        string CSharpType{get;}
        bool Required{get;}
        
        /// <summary>
        /// This attribute defines the minimum value of the instance property
        /// when the type of the instance value is a number. 
        /// </summary>
        decimal? Maximum{get;}
        
        /// <summary>
        /// This attribute defines the maximum value of the instance property
        /// when the type of the instance value is a number. 
        /// </summary>
        decimal? Minimum{get;}
        
        /// <summary>
        /// This attribute indicates if the value of the instance (if the
        /// instance is a number) can not equal the number defined by the
        /// "minimum" attribute.  This is false by default, meaning the instance
        /// value can be greater then or equal to the minimum value. 
        /// </summary>
        bool ExclusiveMinimum{get;} 
        
        /// <summary>
        /// This attribute indicates if the value of the instance (if the
        /// instance is a number) can not equal the number defined by the    
        /// "maximum" attribute.  This is false by default, meaning the instance
        /// value can be less then or equal to the maximum value. 
        /// </summary>
        bool ExclusiveMaximum{get;}
        
        /// <summary>
        /// This attribute defines the minimum number of values in an array when
        /// the array is the instance value. 
        /// </summary>
        int? MinItems{get;}
        
        /// <summary>
        /// This attribute defines the maximum number of values in an array when
        /// the array is the instance value. 
        /// </summary>
        int? MaxItems{get;}
        
        /// <summary>
        /// This attribute indicates that all items in an array instance MUST be
        /// unique (contains no two identical values).
        ///
        /// Two instance are consider equal if they are both of the same type
        /// and:
        /// are null; or [are equal]
        /// </summary>
        bool UniqueItems{get;}
        
        /// <summary>
        /// When the instance value is a string, this provides a regular
        /// expression that a string instance MUST match in order to be valid.
        /// Regular expressions SHOULD follow the regular expression
        //  specification from ECMA 262/Perl 5 
        /// </summary>
        string Pattern{get;}
        
        /// <summary>
        /// When the instance value is a string, this defines the minimum length
        /// of the string.  
        /// </summary>
        int MinLength{get;}
        
        /// <summary>
        /// When the instance value is a string, this defines the maximum length
        /// of the string. 
        /// </summary>
        int MaxLength{get;}
        
        /// <summary>
        /// This provides an enumeration of all possible values that are valid
        /// for the instance property.  This MUST be an array, and each item in
        /// the array represents a possible value for the instance value.  If
        /// this attribute is defined, the instance value MUST be one of the
        /// values in the array in order for the schema to be valid.  Comparison
        /// of enum values uses the same algorithm as defined in "uniqueItems"
        /// (Section 5.15). 
        /// </summary>
        IList<object> EnumValues{get;}
        
        /// <summary>
        ///  This attribute defines the default value of the instance when the
        ///  instance is undefined. 
        /// </summary>
        object Default{get;}
        
        /// <summary>
        /// This attribute is a string that provides a short description of the
        /// instance property. 
        /// </summary>
        string Title{get;}
        
        /// <summary>
        /// This attribute is a string that provides a full description of the of
        /// purpose the instance property.
        /// </summary>
        string Description{get;}
        
        /// <summary>
        /// Defines format as one of a list or a custom format please see  
        /// http://tools.ietf.org/html/draft-zyp-json-schema-03 section 5.23
        /// </summary>
        string Format{get;}
        
        /// <summary>
        /// This attribute defines what value the number instance must be
        /// divisible by with no remainder (the result of the division must be an
        /// integer.)  The value of this attribute SHOULD NOT be 0. 
        /// </summary>
        long DivisibleBy{get;}
        
        /// <summary>
        /// This attribute defines the current URI of this schema (this attribute
        /// is effectively a "self" link).  This URI MAY be relative or absolute.
        /// If the URI is relative it is resolved against the current URI of the
        /// parent schema it is contained in.  If this schema is not contained in
        /// any parent schema, the current URI of the parent schema is held to be
        /// the URI under which this schema was addressed.  If id is missing, the
        /// current URI of a schema is defined to be that of the parent schema.
        /// The current URI of the schema is also used to construct relative
        /// references such as for $ref. 
        /// </summary>
        string Id{get;}
        
        
        /// <summary>
        /// This attribute defines a URI of a schema that contains the full
        /// representation of this schema.  When a validator encounters this
        /// attribute, it SHOULD replace the current schema with the schema
        /// referenced by the value's URI (if known and available) and re-
        /// validate the instance.  This URI MAY be relative or absolute, and
        /// relative URIs SHOULD be resolved against the URI of the current
        /// schema.
        /// </summary>
        string Ref{get;}
    }
}

