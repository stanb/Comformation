using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// Amazon EC2 EC2Fleet OnDemandOptionsRequest
    /// The OnDemandOptionsRequest property type specifies the allocation strategy of On-Demand Instances in an EC2
    /// Fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html
    /// </summary>
    public class OnDemandOptionsRequest
    {

        /// <summary>
        /// AllocationStrategy
        /// The order of the launch template overrides to use in fulfilling On-Demand capacity. If you specify
        /// lowest-price, EC2 Fleet uses price to determine the order, launching the lowest price first. If you
        /// specify prioritized, EC2 Fleet uses the priority that you assigned to each launch template override,
        /// launching the highest priority first. If you do not specify a value, EC2 Fleet defaults to
        /// lowest-price.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

    }
}
