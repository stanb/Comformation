using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet LaunchTemplateOverrides
    /// LaunchTemplateOverrides is a property of the Amazon EC2 SpotFleet SpotFleetRequestConfigData property that
    /// describes overrides for a launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html
    /// </summary>
    public class LaunchTemplateOverrides
    {

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone in which to launch the instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type.
        /// For a complete list of valid values, see InstanceType in LaunchTemplateOverrides in the Amazon EC2
        /// API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// SpotPrice
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotPrice")]
        public Union<string, IntrinsicFunction> SpotPrice { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet in which to launch the instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// The number of units provided by the specified instance type.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<double, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
