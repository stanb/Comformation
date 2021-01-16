using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    /// AWS::Cognito::IdentityPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html
    /// </summary>
    public class IdentityPoolResource : ResourceBase
    {
        public class IdentityPoolProperties
        {
            /// <summary>
            /// PushSync
            /// The configuration options to be applied to the identity pool.
            /// Required: No
            /// Type: PushSync
            /// Update requires: No interruption
            /// </summary>
            public PushSync PushSync { get; set; }

            /// <summary>
            /// CognitoIdentityProviders
            /// The Amazon Cognito user pools and their client IDs.
            /// Required: No
            /// Type: List of CognitoIdentityProvider
            /// Update requires: No interruption
            /// </summary>
            public List<CognitoIdentityProvider> CognitoIdentityProviders { get; set; }

            /// <summary>
            /// CognitoEvents
            /// The events to configure.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CognitoEvents { get; set; }

            /// <summary>
            /// DeveloperProviderName
            /// The &quot;domain&quot; Amazon Cognito uses when referencing your users. This name acts as a placeholder that
            /// allows your backend and the Amazon Cognito service to communicate about the developer provider. For
            /// the DeveloperProviderName, you can use letters and periods (. ), underscores (_), and dashes (-).
            /// Minimum length: 1
            /// Maximum length: 100
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeveloperProviderName { get; set; }

            /// <summary>
            /// CognitoStreams
            /// Configuration options for configuring Amazon Cognito streams.
            /// Required: No
            /// Type: CognitoStreams
            /// Update requires: No interruption
            /// </summary>
            public CognitoStreams CognitoStreams { get; set; }

            /// <summary>
            /// IdentityPoolName
            /// The name of your Amazon Cognito identity pool.
            /// Minimum length: 1
            /// Maximum length: 128
            /// Pattern: [\w\s+=,. @-]+
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IdentityPoolName { get; set; }

            /// <summary>
            /// AllowUnauthenticatedIdentities
            /// Specifies whether the identity pool supports unauthenticated logins.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowUnauthenticatedIdentities { get; set; }

            /// <summary>
            /// SupportedLoginProviders
            /// Key-value pairs that map provider names to provider app IDs.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SupportedLoginProviders { get; set; }

            /// <summary>
            /// SamlProviderARNs
            /// The Amazon Resource Names (ARNs) of the Security Assertion Markup Language (SAML) providers.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SamlProviderARNs { get; set; }

            /// <summary>
            /// OpenIdConnectProviderARNs
            /// The Amazon Resource Names (ARNs) of the OpenID connect providers.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> OpenIdConnectProviderARNs { get; set; }

            /// <summary>
            /// AllowClassicFlow
            /// Enables the Basic (Classic) authentication flow.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowClassicFlow { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::IdentityPool";

        public IdentityPoolProperties Properties { get; } = new IdentityPoolProperties();

    }

    public static class IdentityPoolAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
