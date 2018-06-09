using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// Elastic Load Balancing ListenerRule Actions
    /// Actions is a property of the AWS::ElasticLoadBalancingV2::ListenerRule resource that specifies the actions an
    /// Elastic Load Balancing listener takes when an incoming request meets a listener rule&#39;s condition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-actions.html
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
        /// The type of action. For valid values, see the Type contents for the Action data type in the Elastic
        /// Load Balancing API Reference version 2015-12-01.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
