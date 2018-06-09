using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig MetricDimension
    /// The MetricDimension property type represents a CloudWatch dimension that you specify using a key–value pair.
    /// The Dimensions subproperty of the Amazon EMR InstanceGroupConfig CloudWatchAlarmDefinition property contains a
    /// list of one or more MetricDimension property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-metricdimension.html
    /// </summary>
    public class MetricDimension
    {

        /// <summary>
        /// Key
        /// The dimension name.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The dimension value.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
