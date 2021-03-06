using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster ScalingConstraints
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html
    /// </summary>
    public class ScalingConstraints
    {

        /// <summary>
        /// MaxCapacity
        /// The upper boundary of EC2 instances in an instance group beyond which scaling activities are not
        /// allowed to grow. Scale-out activities will not add instances beyond this boundary.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        /// MinCapacity
        /// The lower boundary of EC2 instances in an instance group below which scaling activities are not
        /// allowed to shrink. Scale-in activities will not terminate instances below this boundary.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

    }
}
