using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// Elastic Load Balancing V2 Action
    /// The Action property type specifies the default actions that the Elastic Load Balancing listener takes when
    /// handling incoming requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-defaultactions.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// AuthenticateCognitoConfig
        /// [HTTPS listener] Information for using Amazon Cognito to authenticate users. Specify only when Type
        /// is authenticate-cognito.
        /// Required: No
        /// Type: AuthenticateCognitoConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticateCognitoConfig")]
        public AuthenticateCognitoConfig AuthenticateCognitoConfig { get; set; }

        /// <summary>
        /// AuthenticateOidcConfig
        /// [HTTPS listener] Information about an identity provider that is compliant with OpenID Connect
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
        /// Valid Range: Minimum value of 1. Maximum value of 50000.
        /// Required: No
        /// Type: Integer
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
        /// The Amazon Resource Name (ARN) of the target group to which Elastic Load Balancing routes the
        /// traffic. Specify only when Type is forward.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

        /// <summary>
        /// Type
        /// The type of action. Each rule must include exactly one of the following types of actions: forward,
        /// fixed-response, or redirect.
        /// Valid values: forward | authenticate-oidc | authenticate-cognito | redirect | fixed-response
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
