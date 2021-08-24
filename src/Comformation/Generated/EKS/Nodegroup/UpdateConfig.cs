using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Nodegroup
{
    /// <summary>
    /// AWS::EKS::Nodegroup UpdateConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-updateconfig.html
    /// </summary>
    public class UpdateConfig
    {

        /// <summary>
        /// MaxUnavailablePercentage
        /// The maximum percentage of nodes unavailable during a version update. This percentage of nodes will
        /// be updated in parallel, up to 100 nodes at once. This value or maxUnavailable is required to have a
        /// value.
        /// Required: No
        /// Type: Double
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxUnavailablePercentage")]
        public Union<double, IntrinsicFunction> MaxUnavailablePercentage { get; set; }

        /// <summary>
        /// MaxUnavailable
        /// The maximum number of nodes unavailable at once during a version update. Nodes will be updated in
        /// parallel. This value or maxUnavailablePercentage is required to have a value. The maximum number is
        /// 100.
        /// Required: No
        /// Type: Double
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxUnavailable")]
        public Union<double, IntrinsicFunction> MaxUnavailable { get; set; }

    }
}
