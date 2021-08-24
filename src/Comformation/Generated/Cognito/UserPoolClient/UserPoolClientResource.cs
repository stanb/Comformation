using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolClient
{
    /// <summary>
    /// AWS::Cognito::UserPoolClient
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html
    /// </summary>
    public class UserPoolClientResource : ResourceBase
    {
        public class UserPoolClientProperties
        {
            /// <summary>
            /// AnalyticsConfiguration
            /// The Amazon Pinpoint analytics configuration for collecting metrics for this user pool.
            /// Note In regions where Pinpoint is not available, Cognito User Pools only supports sending events to
            /// Amazon Pinpoint projects in us-east-1. In regions where Pinpoint is available, Cognito User Pools
            /// will support sending events to Amazon Pinpoint projects within that same region.
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
            /// IdTokenValidity
            /// The time limit, after which the ID token is no longer valid and cannot be used.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> IdTokenValidity { get; set; }

            /// <summary>
            /// AllowedOAuthScopes
            /// The allowed OAuth scopes. Possible values provided by OAuth are: phone, email, openid, and profile.
            /// Possible values provided by AWS are: aws. cognito. signin. user. admin. Custom scopes created in
            /// Resource Servers are also supported.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AllowedOAuthScopes { get; set; }

            /// <summary>
            /// TokenValidityUnits
            /// The units in which the validity times are represented in. Default for RefreshToken is days, and
            /// default for ID and access tokens are hours.
            /// Required: No
            /// Type: TokenValidityUnits
            /// Update requires: No interruption
            /// </summary>
            public TokenValidityUnits TokenValidityUnits { get; set; }

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
            /// Set to true if the client is allowed to follow the OAuth protocol when interacting with Cognito user
            /// pools.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
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
            /// are supported: COGNITO, Facebook, SignInWithApple, Google and LoginWithAmazon.
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
            /// The allowed OAuth flows.
            /// Set to code to initiate a code grant flow, which provides an authorization code as the response.
            /// This code can be exchanged for access tokens with the token endpoint.
            /// Set to implicit to specify that the client should get the access token (and, optionally, ID token,
            /// based on scopes) directly.
            /// Set to client_credentials to specify that the client should get the access token (and, optionally,
            /// ID token, based on scopes) from the token endpoint using a combination of client and client_secret.
            /// Required: No
            /// Type: List of String
            /// Maximum: 3
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AllowedOAuthFlows { get; set; }

            /// <summary>
            /// ExplicitAuthFlows
            /// The authentication flows that are supported by the user pool clients. Flow names without the ALLOW_
            /// prefix are deprecated in favor of new names with the ALLOW_ prefix. Note that values with ALLOW_
            /// prefix cannot be used along with values without ALLOW_ prefix.
            /// Valid values include:
            /// ALLOW_ADMIN_USER_PASSWORD_AUTH: Enable admin based user password authentication flow
            /// ADMIN_USER_PASSWORD_AUTH. This setting replaces the ADMIN_NO_SRP_AUTH setting. With this
            /// authentication flow, Cognito receives the password in the request instead of using the SRP (Secure
            /// Remote Password protocol) protocol to verify passwords. ALLOW_CUSTOM_AUTH: Enable Lambda trigger
            /// based authentication. ALLOW_USER_PASSWORD_AUTH: Enable user password-based authentication. In this
            /// flow, Cognito receives the password in the request instead of using the SRP protocol to verify
            /// passwords. ALLOW_USER_SRP_AUTH: Enable SRP based authentication. ALLOW_REFRESH_TOKEN_AUTH: Enable
            /// authflow to refresh tokens.
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
            /// AccessTokenValidity
            /// The time limit, after which the access token is no longer valid and cannot be used.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> AccessTokenValidity { get; set; }

            /// <summary>
            /// RefreshTokenValidity
            /// The time limit, in days, after which the refresh token is no longer valid and cannot be used.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Maximum: 315360000
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

            /// <summary>
            /// PreventUserExistenceErrors
            /// Use this setting to choose which errors and responses are returned by Cognito APIs during
            /// authentication, account confirmation, and password recovery when the user does not exist in the user
            /// pool. When set to ENABLED and the user does not exist, authentication returns an error indicating
            /// either the username or password was incorrect, and account confirmation and password recovery return
            /// a response indicating a code was sent to a simulated destination. When set to LEGACY, those APIs
            /// will return a UserNotFoundException exception if the user does not exist in the user pool.
            /// Required: No
            /// Type: String
            /// Allowed values: ENABLED | LEGACY
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreventUserExistenceErrors { get; set; }

            /// <summary>
            /// EnableTokenRevocation
            /// Enables or disables token revocation. For more information about revoking tokens, see RevokeToken.
            /// If you don&#39;t include this parameter, token revocation is automatically enabled for the new user pool
            /// client.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableTokenRevocation { get; set; }

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
