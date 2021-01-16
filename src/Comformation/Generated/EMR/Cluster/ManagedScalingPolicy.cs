using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster ManagedScalingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-managedscalingpolicy.html
    /// </summary>
    public class ManagedScalingPolicy
    {

        /// <summary>
        /// ComputeLimits
        /// The EC2 unit limits for a managed scaling policy. The managed scaling activity of a cluster is not
        /// allowed to go above or below these limits. The limit only applies to the core and task nodes. The
        /// master node cannot be scaled after initial configuration.
        /// Required: No
        /// Type: ComputeLimits
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeLimits")]
        public ComputeLimits ComputeLimits { get; set; }

    }
}
