using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html
    /// </summary>
    public class ScalingAction
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-emr-cluster-scalingaction-market
        /// </summary>
        [JsonProperty("Market")]
        public Union<string, IntrinsicFunction> Market { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-emr-cluster-scalingaction-simplescalingpolicyconfiguration
        /// </summary>
        [JsonProperty("SimpleScalingPolicyConfiguration")]
        public Union<SimpleScalingPolicyConfiguration, IntrinsicFunction> SimpleScalingPolicyConfiguration { get; set; }

    }
}
