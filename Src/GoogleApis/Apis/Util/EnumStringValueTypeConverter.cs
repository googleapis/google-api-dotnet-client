/*
Copyright 2011 Google Inc

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

using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Google.Apis.Util
{
    /// <summary>
    /// A specialized type converter which will convert any enum type into the string 
    /// specified in the StringValue attribute.
    /// </summary>
    public class EnumStringValueTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return typeof(Enum).IsAssignableFrom(Utilities.GetNonNullableType(sourceType));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType.Equals(typeof(string));
        }

        public override object ConvertTo(ITypeDescriptorContext context,
                                         CultureInfo culture,
                                         object value,
                                         Type destinationType)
        {
            if (value == null)
            {
                return null;
            }

            Type enumType = value.GetType();
            if (!CanConvertTo(context, destinationType) || !CanConvertFrom(context, enumType))
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }

            // Get the field in the enum.
            FieldInfo field = enumType.GetField(value.ToString());

            // Check if this element has a StringValueAttribute.
            StringValueAttribute attribute = field.GetCustomAttribute<StringValueAttribute>();

            // If it has an attribute, then return the specified text, otherwise use the default overload.
            return attribute != null ? attribute.Text : value.ToString();
        }
    }
}