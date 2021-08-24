using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FinSpace.Environment
{
    /// <summary>
    /// AWS::FinSpace::Environment FederationParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-finspace-environment-federationparameters.html
    /// </summary>
    public class FederationParameters
    {

        /// <summary>
        /// SamlMetadataURL
        /// Provide the metadata URL from your SAML 2. 0 compliant identity provider (IdP).
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1000
        /// Pattern: ^https?://[-a-zA-Z0-9+&amp;amp;@#/%?=~_|!:,. ;]*[-a-zA-Z0-9+&amp;amp;@#/%=~_|]
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SamlMetadataURL")]
        public Union<string, IntrinsicFunction> SamlMetadataURL { get; set; }

        /// <summary>
        /// FederationProviderName
        /// Name of the identity provider (IdP).
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Pattern: [^_\p{Z}][\p{L}\p{M}\p{S}\p{N}\p{P}][^_\p{Z}]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FederationProviderName")]
        public Union<string, IntrinsicFunction> FederationProviderName { get; set; }

        /// <summary>
        /// SamlMetadataDocument
        /// SAML 2. 0 Metadata document from identity provider (IdP).
        /// Required: No
        /// Type: String
        /// Minimum: 1000
        /// Maximum: 10000000
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SamlMetadataDocument")]
        public Union<string, IntrinsicFunction> SamlMetadataDocument { get; set; }

        /// <summary>
        /// ApplicationCallBackURL
        /// The redirect or sign-in URL that should be entered into the SAML 2. 0 compliant identity provider
        /// configuration (IdP).
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1000
        /// Pattern: ^https?://[-a-zA-Z0-9+&amp;amp;@#/%?=~_|!:,. ;]*[-a-zA-Z0-9+&amp;amp;@#/%=~_|]
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationCallBackURL")]
        public Union<string, IntrinsicFunction> ApplicationCallBackURL { get; set; }

        /// <summary>
        /// FederationURN
        /// The Uniform Resource Name (URN). Also referred as Service Provider URN or Audience URI or Service
        /// Provider Entity ID.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^[A-Za-z0-9. _\-:\/#\+]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FederationURN")]
        public Union<string, IntrinsicFunction> FederationURN { get; set; }

        /// <summary>
        /// AttributeMap
        /// SAML attribute name and value. The name must always be Email and the value should be set to the
        /// attribute definition in which user email is set. For example, name would be Email and value
        /// http://schemas. xmlsoap. org/ws/2005/05/identity/claims/emailaddress. Please check your SAML 2. 0
        /// compliant identity provider (IdP) documentation for details.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeMap")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AttributeMap { get; set; }

    }
}
