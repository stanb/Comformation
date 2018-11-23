using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-as-mixedinstancespolicy-instancesdistribution.html
    /// </summary>
    public class InstancesDistribution
    {

        /// <summary>
        /// OnDemandAllocationStrategy
        /// </summary>
        [JsonProperty("OnDemandAllocationStrategy")]
        public Union<string, IntrinsicFunction> OnDemandAllocationStrategy { get; set; }

        /// <summary>
        /// OnDemandBaseCapacity
        /// </summary>
        [JsonProperty("OnDemandBaseCapacity")]
        public Union<int, IntrinsicFunction> OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// OnDemandPercentageAboveBaseCapacity
        /// </summary>
        [JsonProperty("OnDemandPercentageAboveBaseCapacity")]
        public Union<int, IntrinsicFunction> OnDemandPercentageAboveBaseCapacity { get; set; }

        /// <summary>
        /// SpotAllocationStrategy
        /// </summary>
        [JsonProperty("SpotAllocationStrategy")]
        public Union<string, IntrinsicFunction> SpotAllocationStrategy { get; set; }

        /// <summary>
        /// SpotInstancePools
        /// </summary>
        [JsonProperty("SpotInstancePools")]
        public Union<int, IntrinsicFunction> SpotInstancePools { get; set; }

        /// <summary>
        /// SpotMaxPrice
        /// </summary>
        [JsonProperty("SpotMaxPrice")]
        public Union<string, IntrinsicFunction> SpotMaxPrice { get; set; }

    }
}
