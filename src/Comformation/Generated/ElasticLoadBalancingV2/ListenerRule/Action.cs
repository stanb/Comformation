using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule Action
    /// Specifies an action for a listener rule.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-actions.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// AuthenticateCognitoConfig
        /// [HTTPS listeners] Information for using Amazon Cognito to authenticate users. Specify only when Type
        /// is authenticate-cognito.
        /// Required: No
        /// Type: AuthenticateCognitoConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticateCognitoConfig")]
        public AuthenticateCognitoConfig AuthenticateCognitoConfig { get; set; }

        /// <summary>
        /// AuthenticateOidcConfig
        /// [HTTPS listeners] Information about an identity provider that is compliant with OpenID Connect
        /// (OIDC). Specify only when Type is authenticate-oidc.
        /// Required: No
        /// Type: AuthenticateOidcConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticateOidcConfig")]
        public AuthenticateOidcConfig AuthenticateOidcConfig { get; set; }

        /// <summary>
        /// FixedResponseConfig
        /// [Application Load Balancer] Information for creating an action that returns a custom HTTP response.
        /// Specify only when Type is fixed-response.
        /// Required: No
        /// Type: FixedResponseConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FixedResponseConfig")]
        public FixedResponseConfig FixedResponseConfig { get; set; }

        /// <summary>
        /// Order
        /// The order for the action. This value is required for rules with multiple actions. The action with
        /// the lowest value for order is performed first. The final action to be performed must be a forward or
        /// a fixed-response action.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 50000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Order")]
        public Union<int, IntrinsicFunction> Order { get; set; }

        /// <summary>
        /// RedirectConfig
        /// [Application Load Balancer] Information for creating a redirect action. Specify only when Type is
        /// redirect.
        /// Required: No
        /// Type: RedirectConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedirectConfig")]
        public RedirectConfig RedirectConfig { get; set; }

        /// <summary>
        /// TargetGroupArn
        /// The Amazon Resource Name (ARN) of the target group. Specify only when Type is forward.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

        /// <summary>
        /// Type
        /// The type of action. Each rule must include exactly one of the following types of actions: forward,
        /// fixed-response, or redirect.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: authenticate-cognito | authenticate-oidc | fixed-response | forward | redirect
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
