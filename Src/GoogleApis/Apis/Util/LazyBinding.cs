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
using System.IO;
using System.Reflection;

namespace Google.Apis.Util
{
    /// <summary>
    /// Helper class which provides reflection utilities to lazy bind classes and methods.
    /// </summary>
    public static class LazyBinding
    {
        /// <summary>
        /// Finds and returns the assembly with the given name. If none found, throws a
        /// FileNotFound exception.
        /// </summary>
        /// <param name="name">The simple name describing the Assembly.</param>
        /// <exception cref="FileNotFoundException">The assembly was not found.</exception>
        public static Assembly GetAssembly(string name)
        {
            return Assembly.Load(name);
        }

        /// <summary>
        /// Creates a delegate pointing to the specified method. Does not work with static methods.
        /// </summary>
        /// <typeparam name="T">Delegate with the signature of the method.</typeparam>
        /// <param name="target">The target on which this method is executed.</param>
        /// <param name="methodName">The name of the method to call.</param>
        /// <param name="typeArgs">The type arguments describing this method.</param>
        /// <returns>Delegate pointing to the specified method.</returns>
        public static T CreateMethodDelegate<T>(object target, string methodName, params Type[] typeArgs)
        {
            target.ThrowIfNull("target");
            methodName.ThrowIfNullOrEmpty("methodName");
            return CreateMethodDelegate<T>(target, target.GetType().GetMethod(methodName, typeArgs));
        }

        /// <summary>
        /// Creates a delegate pointing to the specified method.
        /// </summary>
        /// <typeparam name="T">Delegate with the signature of the method.</typeparam>
        /// <param name="target">The target on which this method is executed.</param>
        /// <param name="method">The method to which the delegate should point.</param>
        /// <returns>Delegate pointing to the specified method.</returns>
        public static T CreateMethodDelegate<T>(object target, MethodInfo method)
        {
            if (!typeof(Delegate).IsAssignableFrom(typeof(T)))
            {
                throw new ArgumentException("Type has to be a delegate", "<T>");
            }

            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method, true);
        }

        /// <summary>
        /// Creates a delegate pointing to the get method of the specified property. Does not work with static methods.
        /// </summary>
        /// <typeparam name="T">Return type of the getter.</typeparam>
        /// <param name="target">The target on which this delegate is executed.</param>
        /// <param name="propertyName">The name of the property to get the value from.</param>
        /// <returns>Delegate pointing to the specified property getter.</returns>
        public static Func<T> CreatePropertyGetDelegate<T>(object target, string propertyName)
        {
            target.ThrowIfNull("target");
            propertyName.ThrowIfNullOrEmpty("propertyName");
            Type type = target.GetType();
            return CreateMethodDelegate<Func<T>>(target, type.GetProperty(propertyName).GetGetMethod());
        }

        /// <summary>
        /// Creates a delegate pointing to the get method of the specified property.
        /// </summary>
        /// <typeparam name="T">Return type of the getter.</typeparam>
        /// <param name="target">The target on which this delegate is executed.</param>
        /// <param name="property">The property to get the value from.</param>
        /// <returns>Delegate pointing to the specified property getter.</returns>
        public static Func<T> CreatePropertyGetDelegate<T>(object target, PropertyInfo property)
        {
            return CreateMethodDelegate<Func<T>>(target, property.GetGetMethod());
        }
    }
}
