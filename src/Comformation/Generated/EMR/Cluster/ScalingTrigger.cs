using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster ScalingTrigger
    /// The ScalingTrigger property type specifies the conditions that trigger an automatic scaling activity.
    /// ScalingTrigger is the property type for the Trigger subproperty of the Amazon EMR Cluster ScalingRule property
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html
    /// </summary>
    public class ScalingTrigger
    {

        /// <summary>
        /// CloudWatchAlarmDefinition
        /// The definition of a CloudWatch metric alarm. When the defined alarm conditions are met along with
        /// other trigger parameters, scaling activity begins.
        /// Required: Yes
        /// Type: Amazon EMR Cluster CloudWatchAlarmDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchAlarmDefinition")]
        public Union<CloudWatchAlarmDefinition, IntrinsicFunction> CloudWatchAlarmDefinition { get; set; }

    }
}
