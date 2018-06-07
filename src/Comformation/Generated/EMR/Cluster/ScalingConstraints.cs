using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html
    /// </summary>
    public class ScalingConstraints
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html#cfn-emr-cluster-scalingconstraints-maxcapacity
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html#cfn-emr-cluster-scalingconstraints-mincapacity
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

    }
}
