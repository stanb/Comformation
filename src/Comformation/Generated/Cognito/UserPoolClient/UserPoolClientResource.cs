using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolClient
{
    /// <summary>
    /// AWS::Cognito::UserPoolClient
    /// The AWS::Cognito::UserPoolClient resource creates an Amazon Cognito user pool client.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html
    /// </summary>
    public class UserPoolClientResource : ResourceBase
    {
        public class UserPoolClientProperties
        {
            /// <summary>
            /// AnalyticsConfiguration
            /// The Amazon Pinpoint analytics configuration for collecting metrics for this user pool.
            /// Required: No
            /// Type: AnalyticsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public AnalyticsConfiguration AnalyticsConfiguration { get; set; }

            /// <summary>
            /// GenerateSecret
            /// Boolean to specify whether you want to generate a secret for the user pool client being created.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> GenerateSecret { get; set; }

            /// <summary>
            /// CallbackURLs
            /// A list of allowed redirect (callback) URLs for the identity providers.
            /// A redirect URI must:
            /// Be an absolute URI. Be registered with the authorization server. Not include a fragment component.
            /// See OAuth 2. 0 - Redirection Endpoint.
            /// Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing purposes only.
            /// App callback URLs such as myapp://example are also supported.
            /// Required: No
            /// Type: List of String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CallbackURLs { get; set; }

            /// <summary>
            /// AllowedOAuthScopes
            /// A list of allowed OAuth scopes. Currently supported values are &quot;phone&quot;, &quot;email&quot;, &quot;openid&quot;, and
            /// &quot;Cognito&quot;. In addition to these values, custom scopes created in Resource Servers are also
            /// supported.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AllowedOAuthScopes { get; set; }

            /// <summary>
            /// ReadAttributes
            /// The read attributes.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ReadAttributes { get; set; }

            /// <summary>
            /// AllowedOAuthFlowsUserPoolClient
            /// Set to True if the client is allowed to follow the OAuth protocol when interacting with Cognito user
            /// pools.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowedOAuthFlowsUserPoolClient { get; set; }

            /// <summary>
            /// DefaultRedirectURI
            /// The default redirect URI. Must be in the CallbackURLs list.
            /// A redirect URI must:
            /// Be an absolute URI. Be registered with the authorization server. Not include a fragment component.
            /// See OAuth 2. 0 - Redirection Endpoint.
            /// Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing purposes only.
            /// App callback URLs such as myapp://example are also supported.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRedirectURI { get; set; }

            /// <summary>
            /// SupportedIdentityProviders
            /// A list of provider names for the identity providers that are supported on this client. The following
            /// are supported: COGNITO, Facebook, Google and LoginWithAmazon.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SupportedIdentityProviders { get; set; }

            /// <summary>
            /// ClientName
            /// The client name for the user pool client you would like to create.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w\s+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ClientName { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID for the user pool where you want to create a user pool client.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// AllowedOAuthFlows
            /// Set to code to initiate a code grant flow, which provides an authorization code as the response.
            /// This code can be exchanged for access tokens with the token endpoint.
            /// Set to token to specify that the client should get the access token (and, optionally, ID token,
            /// based on scopes) directly.
            /// Required: No
            /// Type: List of String
            /// Maximum: 3
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AllowedOAuthFlows { get; set; }

            /// <summary>
            /// ExplicitAuthFlows
            /// The explicit authentication flows, which can be one of the following: ADMIN_NO_SRP_AUTH,
            /// CUSTOM_AUTH_FLOW_ONLY, or USER_PASSWORD_AUTH.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ExplicitAuthFlows { get; set; }

            /// <summary>
            /// LogoutURLs
            /// A list of allowed logout URLs for the identity providers.
            /// Required: No
            /// Type: List of String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> LogoutURLs { get; set; }

            /// <summary>
            /// RefreshTokenValidity
            /// The time limit, in days, after which the refresh token is no longer valid and cannot be used.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Maximum: 3650
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> RefreshTokenValidity { get; set; }

            /// <summary>
            /// WriteAttributes
            /// The user pool attributes that the app client can write to.
            /// If your app client allows users to sign in through an identity provider, this array must include all
            /// attributes that are mapped to identity provider attributes. Amazon Cognito updates mapped attributes
            /// when users sign in to your application through an identity provider. If your app client lacks write
            /// access to a mapped attribute, Amazon Cognito throws an error when it attempts to update the
            /// attribute. For more information, see Specifying Identity Provider Attribute Mappings for Your User
            /// Pool.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> WriteAttributes { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolClient";

        public UserPoolClientProperties Properties { get; } = new UserPoolClientProperties();

    }

	public static class UserPoolClientAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClientSecret = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClientSecret");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
