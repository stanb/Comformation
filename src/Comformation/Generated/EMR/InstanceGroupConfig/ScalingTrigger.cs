using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig ScalingTrigger
    /// ScalingTrigger is a subproperty of the ScalingRule property type. ScalingTrigger determines the conditions
    /// that trigger an automatic scaling activity.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingtrigger.html
    /// </summary>
    public class ScalingTrigger
    {

        /// <summary>
        /// CloudWatchAlarmDefinition
        /// The definition of a CloudWatch metric alarm. When the defined alarm conditions are met along with
        /// other trigger parameters, scaling activity begins.
        /// Required: Yes
        /// Type: CloudWatchAlarmDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchAlarmDefinition")]
        public CloudWatchAlarmDefinition CloudWatchAlarmDefinition { get; set; }

    }
}
