using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html
    /// </summary>
    public class ScalingTrigger
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html#cfn-emr-cluster-scalingtrigger-cloudwatchalarmdefinition
        /// </summary>
        [JsonProperty("CloudWatchAlarmDefinition")]
        public Union<CloudWatchAlarmDefinition, IntrinsicFunction> CloudWatchAlarmDefinition { get; set; }

    }
}
