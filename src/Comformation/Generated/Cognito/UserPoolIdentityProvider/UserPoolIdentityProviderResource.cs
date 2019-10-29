using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolIdentityProvider
{
    /// <summary>
    /// AWS::Cognito::UserPoolIdentityProvider
    /// The AWS::Cognito::UserPoolIdentityProvider resource creates an identity provider for a user pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolidentityprovider.html
    /// </summary>
    public class UserPoolIdentityProviderResource : ResourceBase
    {
        public class UserPoolIdentityProviderProperties
        {
            /// <summary>
            /// ProviderName
            /// The identity provider name.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: [^_][\p{L}\p{M}\p{S}\p{N}\p{P}][^_]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProviderName { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// AttributeMapping
            /// A mapping of identity provider attributes to standard and custom user pool attributes.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AttributeMapping { get; set; }

            /// <summary>
            /// ProviderDetails
            /// The identity provider details, such as MetadataURL and MetadataFile.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ProviderDetails { get; set; }

            /// <summary>
            /// ProviderType
            /// The identity provider type.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: Facebook | Google | LoginWithAmazon | OIDC | SAML
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProviderType { get; set; }

            /// <summary>
            /// IdpIdentifiers
            /// A list of identity provider identifiers.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> IdpIdentifiers { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolIdentityProvider";

        public UserPoolIdentityProviderProperties Properties { get; } = new UserPoolIdentityProviderProperties();

    }
}
