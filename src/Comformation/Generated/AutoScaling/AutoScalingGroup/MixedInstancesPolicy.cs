using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-as-group-mixedinstancespolicy.html
    /// </summary>
    public class MixedInstancesPolicy
    {

        /// <summary>
        /// InstancesDistribution
        /// </summary>
        [JsonProperty("InstancesDistribution")]
        public InstancesDistribution InstancesDistribution { get; set; }

        /// <summary>
        /// LaunchTemplate
        /// </summary>
        [JsonProperty("LaunchTemplate")]
        public LaunchTemplate LaunchTemplate { get; set; }

    }
}
