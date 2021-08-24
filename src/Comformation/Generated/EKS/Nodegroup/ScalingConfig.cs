using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Nodegroup
{
    /// <summary>
    /// AWS::EKS::Nodegroup ScalingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-scalingconfig.html
    /// </summary>
    public class ScalingConfig
    {

        /// <summary>
        /// MinSize
        /// The minimum number of nodes that the managed node group can scale in to.
        /// Required: No
        /// Type: Double
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinSize")]
        public Union<double, IntrinsicFunction> MinSize { get; set; }

        /// <summary>
        /// DesiredSize
        /// The current number of nodes that the managed node group should maintain.
        /// Required: No
        /// Type: Double
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DesiredSize")]
        public Union<double, IntrinsicFunction> DesiredSize { get; set; }

        /// <summary>
        /// MaxSize
        /// The maximum number of nodes that the managed node group can scale out to. For information about the
        /// maximum number that you can specify, see Amazon EKS service quotas in the Amazon EKS User Guide.
        /// Required: No
        /// Type: Double
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxSize")]
        public Union<double, IntrinsicFunction> MaxSize { get; set; }

    }
}
