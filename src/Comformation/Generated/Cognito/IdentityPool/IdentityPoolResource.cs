using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    /// AWS::Cognito::IdentityPool
    /// The AWS::Cognito::IdentityPool resource creates an Amazon Cognito identity pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html
    /// </summary>
    public class IdentityPoolResource : ResourceBase
    {
        public class IdentityPoolProperties
        {
            /// <summary>
            /// PushSync
            /// Configuration options to be applied to the identity pool.
            /// Required: No
            /// Type: Amazon Cognito IdentityPool PushSync
            /// Update requires: No interruption
            /// </summary>
			public PushSync PushSync { get; set; }

            /// <summary>
            /// CognitoIdentityProviders
            /// An array of Amazon Cognito user pools and their client IDs.
            /// Required: No
            /// Type: An array of Amazon Cognito IdentityPool CognitoIdentityProvider.
            /// Update requires: No interruption
            /// </summary>
			public List<CognitoIdentityProvider> CognitoIdentityProviders { get; set; }

            /// <summary>
            /// CognitoEvents
            /// The events to configure.
            /// Required: No
            /// Type: String to String map
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CognitoEvents { get; set; }

            /// <summary>
            /// DeveloperProviderName
            /// The &quot;domain&quot; by which Amazon Cognito will refer to your users. This name acts as a placeholder that
            /// allows your backend and the Amazon Cognito service to communicate about the developer provider. For
            /// the DeveloperProviderName, you can use letters and periods (. ), underscores (_), and dashes (-).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// MinLength: 1
            /// MaxLength: 100
            /// </summary>
			public Union<string, IntrinsicFunction> DeveloperProviderName { get; set; }

            /// <summary>
            /// CognitoStreams
            /// Configuration options for configuring Amazon Cognito streams.
            /// Required: No
            /// Type: Amazon Cognito IdentityPool CognitoStreams
            /// Update requires: No interruption
            /// </summary>
			public CognitoStreams CognitoStreams { get; set; }

            /// <summary>
            /// IdentityPoolName
            /// The name of your Amazon Cognito identity pool.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// MinLength: 1
            /// MaxLength: 128
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
            /// Type: String to String map
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SupportedLoginProviders { get; set; }

            /// <summary>
            /// SamlProviderARNs
            /// A list of Amazon Resource Names (ARNs) of Security Assertion Markup Language (SAML) providers.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SamlProviderARNs { get; set; }

            /// <summary>
            /// OpenIdConnectProviderARNs
            /// A list of ARNs for the OpendID Connect provider.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> OpenIdConnectProviderARNs { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::IdentityPool";
        
        public IdentityPoolProperties Properties { get; } = new IdentityPoolProperties();

    }

	public static class IdentityPoolAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
