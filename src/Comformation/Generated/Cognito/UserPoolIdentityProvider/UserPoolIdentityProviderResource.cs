using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolIdentityProvider
{
    /// <summary>
    /// AWS::Cognito::UserPoolIdentityProvider
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
            /// The identity provider details. The following list describes the provider detail keys for each
            /// identity provider type.
            /// For Google and Login with Amazon: client_id client_secret authorize_scopes For Facebook: client_id
            /// client_secret authorize_scopes api_version For Sign in with Apple: client_id team_id key_id
            /// private_key authorize_scopes For OIDC providers: client_id client_secret attributes_request_method
            /// oidc_issuer authorize_scopes authorize_url if not available from discovery URL specified by
            /// oidc_issuer key token_url if not available from discovery URL specified by oidc_issuer key
            /// attributes_url if not available from discovery URL specified by oidc_issuer key jwks_uri if not
            /// available from discovery URL specified by oidc_issuer key For SAML providers: MetadataFile OR
            /// MetadataURL IDPSignout optional
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
            /// Allowed values: Facebook | Google | LoginWithAmazon | OIDC | SAML | SignInWithApple
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
