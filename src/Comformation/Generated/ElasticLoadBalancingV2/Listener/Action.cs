using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// Order
        /// The order for the action. This value is required for rules with multiple actions. The action with
        /// the lowest value for order is performed first.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 50000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Order")]
        public Union<int, IntrinsicFunction> Order { get; set; }

        /// <summary>
        /// TargetGroupArn
        /// The Amazon Resource Name (ARN) of the target group. Specify only when Type is forward and you want
        /// to route to a single target group. To route to one or more target groups, use ForwardConfig instead.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

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
        /// Type
        /// The type of action.
        /// Required: Yes
        /// Type: String
        /// Allowed values: authenticate-cognito | authenticate-oidc | fixed-response | forward | redirect
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

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
        /// ForwardConfig
        /// Information for creating an action that distributes requests among one or more target groups. For
        /// Network Load Balancers, you can specify a single target group. Specify only when Type is forward. If
        /// you specify both ForwardConfig and TargetGroupArn, you can specify only one target group using
        /// ForwardConfig and it must be the same target group specified in TargetGroupArn.
        /// Required: No
        /// Type: ForwardConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForwardConfig")]
        public ForwardConfig ForwardConfig { get; set; }

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

    }
}
