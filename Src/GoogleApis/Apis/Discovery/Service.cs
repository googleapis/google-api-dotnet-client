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
using System.IO;
using System.Linq;
using System.Text;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Testing;
using Google.Apis.Util;
using Google.Apis.Discovery.Schema;
using Newtonsoft.Json;

namespace Google.Apis.Discovery
{
    #region BaseService

    /// <summary>
    /// Represents the basic implementation of a service
    /// </summary>
    public abstract class BaseService : ServiceObject, IService
    {
        /// <summary>
        /// Name of the method used for serialization (object -> json)
        /// </summary>
        public const string SerializationMethodName = "SerializeRequest";

        /// <summary>
        /// Name of the method used for deserialization (json -> object)
        /// </summary>
        public const string DeserializationMethodName = "DeserializeResponse";

        /// <summary>
        /// Name of the property defining the ISerializer
        /// </summary>
        public const string SerializerPropertyName = "Serializer";

        private static readonly ILogger logger = ApplicationContext.Logger.ForType<BaseService>();

        protected internal readonly JsonDictionary information;
        private IResource rootResource;
        private IDictionary<String, ISchema> schemas;
        private ISerializer serializer;
        private bool gzipSupport = true;

        internal BaseService(IServiceFactory factory, JsonDictionary values, FactoryParameters param)
            : this(factory)
        {
            values.ThrowIfNull("values");
            param = param ?? new FactoryParameters();

            // Set required properties
            Version = values.GetMandatoryValue<string>("version");
            Name = values.GetMandatoryValue<string>("name");
            information = values;

            // Set optional properties
            Id = values.GetValueAsNull("id") as string;
            Labels = values.GetValueAsStringListOrEmpty("labels").ToList().AsReadOnly();
            Features = values.GetValueAsStringListOrEmpty("features").ToList().AsReadOnly();
            DocumentationLink = values.GetValueAsNull("documentationLink") as string;
            Protocol = values.GetValueAsNull("protocol") as string;
            Description = values.GetValueAsNull("description") as string;
            Title = values.GetValueAsNull("title") as string;
            Scopes = LoadScopes();
            Parameters = LoadParameters();

            // Load resources
            rootResource = CreateResource(new KeyValuePair<string, object>("", information));

            // Determine the Server URL and (optional) Base Path
            param.ServerUrl.ThrowIfNull("param.ServerUrl");
            ServerUrl = param.ServerUrl;
            BasePath = param.BasePath;
        }

        private BaseService(IServiceFactory factory)
            : base(factory)
        {
            Serializer = new NewtonsoftJsonSerializer();
        }

        protected string ServerUrl { get; set; }
        protected string BasePath { get; set; }

        #region IService Members

        public string Name { get; private set; }
        public string Version { get; private set; }
        public string Description { get; private set; }
        public string Title { get; private set; }

        public string Id { get; private set; }
        public IList<string> Labels { get; private set; }
        public IList<string> Features { get; private set; }
        public IDictionary<string, Scope> Scopes { get; private set; }
        public IDictionary<string, IParameter> Parameters { get; private set; }

        public string DocumentationLink { get; private set; }
        public string Protocol { get; private set; }

        public DiscoveryVersion DiscoveryVersion { get { return Factory.Version; } }

        public Uri BaseUri
        {
            get
            {
                if (ServerUrl.EndsWith("/") && BasePath.StartsWith("/"))
                {
                    return new Uri(ServerUrl.Substring(0, ServerUrl.Length - 1) + BasePath);
                }
                if (!ServerUrl.EndsWith("/") && !BasePath.StartsWith("/"))
                {
                    return new Uri(ServerUrl + "/" + BasePath);
                }
                return new Uri(ServerUrl + BasePath);
            }
        }

        public Uri RpcUri
        {
            get { return new Uri(information[ServiceFactory.RpcUrl] as string); }
        }

        public IDictionary<string, IResource> Resources
        {
            get { return rootResource.Resources; }
        }

        public virtual IDictionary<string, ISchema> Schemas
        {
            get
            {
                if (schemas != null)
                {
                    return schemas;
                }

                logger.Debug("Fetching Schemas for service {0}", Name);
                if (information.ContainsKey(ServiceFactory.Schemas))
                {
                    var js = (JsonDictionary)information[ServiceFactory.Schemas];
                    schemas = ParseSchemas(js);
                }
                else
                {
                    // Return an empty dictionary instead of null.
                    schemas = new Dictionary<string, ISchema>(0).AsReadOnly();
                }

                return schemas;
            }
        }

        public ISerializer Serializer
        {
            get { return serializer; }
            set
            {
                value.ThrowIfNull("value");
                serializer = value;
            }
        }

        /// <summary>
        /// Creates a Request Object based on the HTTP Method Type.
        /// </summary>
        public IRequest CreateRequest(string resource, string methodName)
        {
            var method = GetResource(this, resource).Methods[methodName];
            var request = Request.CreateRequest(this, method);

            return request;
        }
        
        /// <summary>
        /// Loads the set of scopes from the json information dictionary and parses it into a dictionary.
        /// Always returns a valid dictionary.
        /// </summary>
        [VisibleForTestOnly]
        internal IDictionary<string, Scope> LoadScopes()
        {
            Dictionary<string, Scope> scopes = new Dictionary<string, Scope>();
            
            // Access the "auth" node.
            var authObj = information.GetValueAsNull("auth") as JsonDictionary;
            if (authObj == null)
            {
                return scopes;
            }

            // Access the "oauth2" subnode.
            var oauth2Obj = authObj.GetValueAsNull("oauth2") as JsonDictionary;
            if (oauth2Obj == null)
            {
                return scopes;
            }

            // Access the "scopes" subnode.
            var scopesObj = oauth2Obj.GetValueAsNull("scopes") as JsonDictionary;
            if (scopesObj == null)
            {
                return scopes;
            }

            // Iterate through all scopes.
            foreach (KeyValuePair<string,object> pair in scopesObj)
            {
                // Create a new scope object.
                var scope = new Scope();
                scope.ID = pair.Key;

                var data = pair.Value as JsonDictionary;
                if (data != null)
                {
                    scope.Description = data.GetValueAsNull("description") as string;
                }

                // Add it to the scopes dictionary.
                scopes.Add(scope.ID, scope);
            }
            
            return scopes;
        }

        /// <summary>
        /// Loads the common parameters from the json information dictionary and parses it into a dictionary.
        /// Always returns a valid dictionary.
        /// </summary>
        [VisibleForTestOnly]
        internal IDictionary<string, IParameter> LoadParameters()
        {
          // Access the "parameters" node for service-wide parameters.
          var paramsObj = information.GetValueAsNull("parameters") as JsonDictionary;
          if (paramsObj != null)
          {
            return paramsObj.Select(p => CreateParameter(p))
              .ToDictionary(p => p.Name);
          }
          else
          {
            return new Dictionary<string, IParameter>();
          }
        }


        /// <summary>
        /// Retrieves a resource using the full resource name.
        /// Example:
        ///     TopResource.SubResource will retrieve the SubResource which can be found under the TopResource.
        /// </summary>
        [VisibleForTestOnly]
        internal static IResource GetResource(IResource root, string fullResourceName)
        {
            fullResourceName.ThrowIfNull("fullResourceName");
            if (string.IsNullOrEmpty(fullResourceName))
            {
                return root;
            }

            string[] split = fullResourceName.Split(new[] { '.' });
            string topResourceName = split[0];
            IResource topResource = root.Resources[topResourceName];

            if (split.Length <= 1)
            {
                // This is the resource we are looking for.
                return topResource;
            }
            
            // Retrieve the top resource, and re-run this method on it.
            string fullSubresourceName = String.Join(".", split, 1, split.Length - 1);
            return GetResource(topResource, fullSubresourceName);
        }

        public string SerializeRequest(object obj)
        {
            if (HasFeature(Discovery.Features.LegacyDataResponse))
            {
                // Legacy path
                var request = new StandardResponse<object> { Data = obj };
                return Serializer.Serialize(request);
            }

            // New v1.0 path
            return Serializer.Serialize(obj);
        }

        /// <summary>
        /// Deserializes an error response into a <see cref="RequestError"/> object
        /// </summary>
        /// <exception cref="GoogleApiException">If no error is found in the response.</exception>
        /// <param name="input"><see cref="IResponse"/> containing an error.</param>
        /// <returns>The <see cref="RequestError"/> object deserialized from the stream.</returns>
        public RequestError DeserializeError(IResponse input)
        {
            Serializer.ThrowIfNull("Serializer");
            input.ThrowIfNull("input");
            input.Stream.ThrowIfNull("input.Stream");

            // Read in the entire content.
            var response = Serializer.Deserialize<StandardResponse<object>>(input.ReadToEnd());
            if (response.Error == null)
            {
                throw new GoogleApiException(this, 
                    "An Error occured, but the error response could not be deserialized.");
            }

            return response.Error;
        }

        public T DeserializeResponse<T>(IResponse input)
        {
            input.ThrowIfNull("input");
            input.Stream.ThrowIfNull("input.Stream");
            Serializer.ThrowIfNull("Serializer");

            // Read in the entire content.
            string text = input.ReadToEnd();

            // If a string is request, don't parse the response.
            if (typeof(T).Equals(typeof(string)))
            {
                return (T) (object) text;
            }

            // Check if there was an error returned. The error node is returned in both paths
            // Deserialize the stream based upon the format of the stream.
            if (HasFeature(Discovery.Features.LegacyDataResponse))
            {
                // Legacy path (deprecated!)
                StandardResponse<T> response;
                try
                {
                    response = Serializer.Deserialize<StandardResponse<T>>(text);
                }
                catch(JsonReaderException ex)
                {
                    throw new GoogleApiException(this, "Failed to parse response from server as json ["+text+"]", ex);
                }

                if (response.Error != null)
                {
                    throw new GoogleApiException(this, "Server error - " + response.Error);
                }
            
                if (response.Data == null)
                {
                    throw new GoogleApiException(this, "The response could not be deserialized.");
                }

                return response.Data;
            }

            // New path: Deserialize the object directly.
            T result = default(T);
            try
            {
                result = Serializer.Deserialize<T>(text);
            }
            catch (JsonReaderException ex)
            {
                throw new GoogleApiException(this, "Failed to parse response from server as json [" + text + "]", ex);
            }

            // If this schema/object provides an error container, check it.
            if (result is IDirectResponseSchema)
            {
                var response = (IDirectResponseSchema) result;

                // Set the e-tag.
                response.ETag = input.ETag;

                // Check for errors.
                if (response.Error != null)
                {
                    throw new GoogleApiException(this, "Server error - " + response.Error);
                }
            }

            return result;
        }

        public bool HasFeature(Features feature)
        {
            return Features.Contains(feature.GetStringValue());
        }

        public bool GZipEnabled
        {
            get
            {
#if SILVERLIGHT
                return false;
#endif
                return gzipSupport;
            }
            set
            {
#if SILVERLIGHT
                throw new NotImplementedException("GZip Support is not yet available on Silverlight.");
#endif
                gzipSupport = value;
            }
        }

        #endregion

        internal static IDictionary<string, ISchema> ParseSchemas(JsonDictionary js)
        {
            js.ThrowIfNull("values");

            RemoveAnnotations(js, 0);

            var working = new Dictionary<string, ISchema>();

            var resolver = new FutureJsonSchemaResolver();
            foreach (KeyValuePair<string, object> kvp in js)
            {
                logger.Debug("Found schema {0}", kvp.Key);
                var serilizer = new JsonSerializer();
                var textWriter = new StringWriter();
                serilizer.Serialize(textWriter, kvp.Value);
                string result = textWriter.ToString();
                ISchema schema = new SchemaImpl(kvp.Key, result, resolver);
                working.Add(schema.Name, schema);
            }

            resolver.ResolveAndVerify();

            return working.AsReadOnly();
        }

        /// <summary>
        /// Newtonsoft JSon parser fails to parse json containing a "$ref" and an adjacent
        /// object property. Google service discovery currently generates this in the "annotations"
        /// property.
        /// </summary>
        /// <param name="js"></param>
        /// <param name="depth"></param>
        internal static void RemoveAnnotations(JsonDictionary js, int depth)
        {
            if (js.ContainsKey("$ref") && js.ContainsKey("annotations") && depth >= 3)
            {
                js.Remove("annotations");
            }

            foreach (var jd in js.Values
                .Where(o => o is JsonDictionary)
                .Select(o => o as JsonDictionary))
            {
                RemoveAnnotations(jd, depth + 1);
            }
        }

        /// <summary>
        /// Returns the discovery document describing this service.
        /// </summary>
        /// <returns>Json formatted discovery document.</returns>
        public string GetDiscoveryDocument()
        {
            return serializer.Serialize(information);
        }
        public Dictionary<string, IMethod> Methods
        {
            get { return rootResource.Methods; }
        }

        public IResource Parent
        {
            get { return rootResource.Parent; }
        }

        public string Path
        {
            get { return rootResource.Path; }
        }

        public bool IsServiceResource
        {
            get { return rootResource.IsServiceResource; }
        }
    }

    #endregion

    #region Service V1.0

    /// <summary>
    /// Represents a Service as defined in Discovery V1.0
    /// </summary>
    internal class ServiceV1_0 : BaseService
    {
        private const string BasePathField = "basePath";

        /// <summary>
        /// Creates a v1.0 service
        /// </summary>
        public ServiceV1_0(IServiceFactory factory, JsonDictionary values, FactoryParameters param)
            : base(factory, values, param)
        {
            // If no BasePath has been set, then retrieve it from the json document
            if (BasePath.IsNullOrEmpty())
            {
                BasePath = information.GetMandatoryValue<string>(BasePathField);
            }
        }
    }

    #endregion

    #region Service V0.3

    /// <summary>
    /// Represents a Service as defined in Discovery V0.3
    /// </summary>
    internal class ServiceV0_3 : BaseService
    {
        private const string RestBasePathField = "restBasePath";

        /// <summary>
        /// Creates a v0.3 service
        /// </summary>
        public ServiceV0_3(IServiceFactory factory, JsonDictionary values, FactoryParameters param)
            : base(factory, values, param)
        {
            // If no BasePath has been set, then retrieve it from the json document
            if (BasePath.IsNullOrEmpty())
            {
                BasePath = information.GetMandatoryValue<string>(RestBasePathField);
            }
        }
    }

    #endregion
}