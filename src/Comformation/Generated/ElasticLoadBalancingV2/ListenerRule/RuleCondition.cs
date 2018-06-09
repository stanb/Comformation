using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// Elastic Load Balancing ListenerRule Conditions
    /// Conditions is a property of the AWS::ElasticLoadBalancingV2::ListenerRule resource that specifies the
    /// conditions when an Elastic Load Balancing listener rule takes effect.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-conditions.html
    /// </summary>
    public class RuleCondition
    {

        /// <summary>
        /// Field
        /// The name of the condition that you want to define, such as path-pattern (which forwards requests
        /// based on the URL of the request).
        /// For valid values, see the Field contents for the RuleCondition data type in the Elastic Load
        /// Balancing API Reference version 2015-12-01.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Field")]
        public Union<string, IntrinsicFunction> Field { get; set; }

        /// <summary>
        /// Values
        /// The value for the field that you specified in the Field property.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Values")]
        public Union<List<string>, IntrinsicFunction> Values { get; set; }

    }
}
