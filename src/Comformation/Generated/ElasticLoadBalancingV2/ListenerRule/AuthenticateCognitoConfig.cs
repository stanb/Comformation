using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// Elastic Load Balancing V2 AuthenticateCognitoConfig
    /// The AuthenticateCognitoConfig property type specifies request parameters to use when integrating with Amazon
    /// Cognito to authenticate users.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html
    /// </summary>
    public class AuthenticateCognitoConfig
    {

        /// <summary>
        /// AuthenticationRequestExtraParams
        /// The query parameters (up to 10) to include in the redirect request to the authorization endpoint.
        /// Required: No
        /// Type: Type: String to String map
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticationRequestExtraParams")]
        public Dictionary<string, Union<string, IntrinsicFunction>> AuthenticationRequestExtraParams { get; set; }

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
        /// Required: Yes
        /// Type: Type: Number
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionTimeout")]
        public Union<long, IntrinsicFunction> SessionTimeout { get; set; }

        /// <summary>
        /// UserPoolArn
        /// The Amazon Resource Name (ARN) of the Amazon Cognito user pool.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserPoolArn")]
        public Union<string, IntrinsicFunction> UserPoolArn { get; set; }

        /// <summary>
        /// UserPoolClientId
        /// The ID of the Amazon Cognito user pool client.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserPoolClientId")]
        public Union<string, IntrinsicFunction> UserPoolClientId { get; set; }

        /// <summary>
        /// UserPoolDomain
        /// The domain prefix or fully-qualified domain name of the Amazon Cognito user pool.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserPoolDomain")]
        public Union<string, IntrinsicFunction> UserPoolDomain { get; set; }

    }
}
