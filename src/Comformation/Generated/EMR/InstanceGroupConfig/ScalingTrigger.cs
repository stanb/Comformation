using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig ScalingTrigger
    /// The ScalingTrigger property type specifies the conditions that trigger an automatic scaling activity.
    /// ScalingTrigger is the property type for the Trigger subproperty of the Amazon EMR InstanceGroupConfig
    /// ScalingRule property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingtrigger.html
    /// </summary>
    public class ScalingTrigger
    {

        /// <summary>
        /// CloudWatchAlarmDefinition
        /// The definition of a CloudWatch metric alarm. When the defined alarm conditions are met along with
        /// other trigger parameters, scaling activity begins.
        /// Required: Yes
        /// Type: Amazon EMR InstanceGroupConfig CloudWatchAlarmDefinition
        /// </summary>
        [JsonProperty("CloudWatchAlarmDefinition")]
        public CloudWatchAlarmDefinition CloudWatchAlarmDefinition { get; set; }

    }
}
