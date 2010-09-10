/*
Copyright 2010 Google Inc

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
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Google.Apis.Discovery;

namespace Google.Apis
{
	/// <summary>
	/// Logic for validating that a method is correct
	/// </summary>
	public class MethodValidator
	{
		public Method CurrentMethod {get; private set;}
		public Dictionary<string, string> Parameters {get; private set;}
		
		public MethodValidator (Method method, Dictionary<string, string> parameters)
		{
			this.CurrentMethod = method;
			this.Parameters = parameters;
		}
		
		/// <summary>
		/// Validates all the parameters provided.
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool ValidateAllParameters() {
			var parameters = CurrentMethod.Parameters;
			// Itterate accross all the parameters in the discovery document, and check them against supplied arguments.
			foreach(var parameter in parameters) {
				var parameterInfo = parameter.Value;
				
				if(this.ValidateParameter(parameterInfo) == false)
				{
					return false;
				}
			}
			
			return true;
		}
		
		/// <summary>
		/// Validates a parameter.
		/// 
		/// Checks to see if it is required, or if it needs regex validation.
		/// </summary>
		/// <param name="param">
		/// A <see cref="Parameter"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool ValidateParameter(Parameter param) {
			string currentParam;
			bool parameterPresent = Parameters.TryGetValue(param.Name, out currentParam);
				
			// If a required parameter is not present. bail
			if(param.Required && String.IsNullOrEmpty(currentParam)) {
				return false;
			}
			
			if(parameterPresent == false) {
				// The parameter is not present in the input and is not required, skip validation.
				return true;	
			}
			else {
				// The parameter is present, validte the regex.
				bool isValidData = ValidateRegex(param, currentParam.ToString());
				if(isValidData == false) {
					return false;
				}
			}
			
			return true;
		}
		
		/// <summary>
		/// Validates a parameters value against the methods regex.
		/// </summary>
		/// <param name="pattern">
		/// A <see cref="System.String"/>
		/// </param>
		/// <param name="stringValue">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool ValidateRegex(Parameter param, string paramValue) {
			string pattern = param.Pattern;
			string stringValue = paramValue;
			
			Regex r = new Regex(pattern);
			
			return r.IsMatch(stringValue);;	
		}
	}
}

