using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// Elastic Load Balancing Listener Action
    /// The Action property type specifies the default actions that the Elastic Load Balancing listener takes when
    /// handling incoming requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-defaultactions.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// TargetGroupArn
        /// The Amazon Resource Name (ARN) of the target group to which Elastic Load Balancing routes the
        /// traffic.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

        /// <summary>
        /// Type
        /// The type of action.
        /// Valid values: forward
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
