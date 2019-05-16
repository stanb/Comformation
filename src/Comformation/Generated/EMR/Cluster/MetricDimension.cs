using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster MetricDimension
    /// MetricDimension is a subproperty of the CloudWatchAlarmDefinition property type. MetricDimension specifies a
    /// CloudWatch dimension, which is specified with a Key Value pair. The key is known as a Name in CloudWatch. By
    /// default, Amazon EMR uses one dimension whose Key is JobFlowID and Value is a variable representing the cluster
    /// ID, which is ${emr. clusterId}. This enables the automatic scaling rule for EMR to bootstrap when the cluster
    /// ID becomes available during cluster creation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-metricdimension.html
    /// </summary>
    public class MetricDimension
    {

        /// <summary>
        /// Key
        /// The dimension name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The dimension value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
