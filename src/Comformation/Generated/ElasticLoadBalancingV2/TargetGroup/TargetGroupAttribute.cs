using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// Elastic Load Balancing TargetGroup TargetGroupAttributes
    /// TargetGroupAttributes is a property of the AWS::ElasticLoadBalancingV2::TargetGroup resource that configures
    /// settings for an Elastic Load Balancing target group. For more information, see Target Group Attributes in the
    /// Application Load Balancers Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetgroupattributes.html
    /// </summary>
    public class TargetGroupAttribute
    {

        /// <summary>
        /// Key
        /// The name of the attribute that you want to configure. For the list of attributes that you can
        /// configure, see the Key contents for the TargetGroupAttribute data type in the Elastic Load Balancing
        /// API Reference version 2015-12-01.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// A value for the attribute.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
