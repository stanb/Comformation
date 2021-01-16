using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig ScalingTrigger
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
