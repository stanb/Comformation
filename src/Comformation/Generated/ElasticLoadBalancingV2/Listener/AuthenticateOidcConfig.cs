using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// Elastic Load Balancing Listener AuthenticateOidcConfig
    /// The AuthenticateOidcConfig property type specifies request parameters when using an identity provider (IdP)
    /// that is compliant with OpenID Connect (OIDC) to authenticate users.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html
    /// </summary>
    public class AuthenticateOidcConfig
    {

        /// <summary>
        /// AuthenticationRequestExtraParams
        /// The query parameters (up to 10) to include in the redirect request to the authorization endpoint.
        /// Required: No
        /// Type: Map of string-to-string values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticationRequestExtraParams")]
        public Dictionary<string, Union<string, IntrinsicFunction>> AuthenticationRequestExtraParams { get; set; }

        /// <summary>
        /// AuthorizationEndpoint
        /// The authorization endpoint of the IdP. This must be a full URL, including the HTTPS protocol, the
        /// domain, and the path.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizationEndpoint")]
        public Union<string, IntrinsicFunction> AuthorizationEndpoint { get; set; }

        /// <summary>
        /// ClientId
        /// The OAuth 2. 0 client identifier.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientId")]
        public Union<string, IntrinsicFunction> ClientId { get; set; }

        /// <summary>
        /// ClientSecret
        /// The OAuth 2. 0 client secret.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientSecret")]
        public Union<string, IntrinsicFunction> ClientSecret { get; set; }

        /// <summary>
        /// Issuer
        /// The OIDC issuer identifier of the IdP. This must be a full URL, including the HTTPS protocol, the
        /// domain, and the path.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Issuer")]
        public Union<string, IntrinsicFunction> Issuer { get; set; }

        /// <summary>
        /// OnUnauthenticatedRequest
        /// The behavior if the user is not authenticated. The following are possible values:
        /// deny: Return an HTTP 401 Unauthorized error. allow: Allow the request to be forwarded to the target.
        /// authenticate: Redirect the request to the IdP authorization endpoint. This is the default value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnUnauthenticatedRequest")]
        public Union<string, IntrinsicFunction> OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// Scope
        /// The set of user claims to be requested from the IdP. The default is openid.
        /// To verify which scope values your IdP supports and how to separate multiple values, see the
        /// documentation for your IdP.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scope")]
        public Union<string, IntrinsicFunction> Scope { get; set; }

        /// <summary>
        /// SessionCookieName
        /// The name of the cookie used to maintain session information. The default is AWSELBAuthSessionCookie.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionCookieName")]
        public Union<string, IntrinsicFunction> SessionCookieName { get; set; }

        /// <summary>
        /// SessionTimeout
        /// The maximum duration of the authentication session, in seconds. The default is 604800 seconds (7
        /// days).
        /// Required: Number
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionTimeout")]
        public Union<long, IntrinsicFunction> SessionTimeout { get; set; }

        /// <summary>
        /// TokenEndpoint
        /// The maximum duration of the authentication session, in seconds. The default is 604800 seconds (7
        /// days).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TokenEndpoint")]
        public Union<string, IntrinsicFunction> TokenEndpoint { get; set; }

        /// <summary>
        /// UserInfoEndpoint
        /// The maximum duration of the authentication session, in seconds. The default is 604800 seconds (7
        /// days).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserInfoEndpoint")]
        public Union<string, IntrinsicFunction> UserInfoEndpoint { get; set; }

    }
}