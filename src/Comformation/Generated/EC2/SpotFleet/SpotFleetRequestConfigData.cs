using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon EC2 SpotFleet SpotFleetRequestConfigData
    /// SpotFleetRequestConfigData is a property of the AWS::EC2::SpotFleet resource that defines the configuration of
    /// a Spot fleet request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html
    /// </summary>
    public class SpotFleetRequestConfigData
    {

        /// <summary>
        /// AllocationStrategy
        /// Indicates how to allocate the target capacity across the Spot pools that you specified in the Spot
        /// fleet request. For valid values, see SpotFleetRequestConfigData in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// ExcessCapacityTerminationPolicy
        /// Indicates whether running Spot instances are terminated if you decrease the target capacity of the
        /// Spot fleet request below the current size of the Spot fleet. For valid values, see
        /// SpotFleetRequestConfigData in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcessCapacityTerminationPolicy")]
        public Union<string, IntrinsicFunction> ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// IamFleetRole
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that grants the
        /// Spot fleet the ability to bid on, launch, and terminate instances on your behalf. For more
        /// information, see Spot Fleet Prerequisites in the Amazon EC2 User Guide for Linux Instances.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IamFleetRole")]
        public Union<string, IntrinsicFunction> IamFleetRole { get; set; }

        /// <summary>
        /// LaunchSpecifications
        /// The launch specifications for the Spot fleet request.
        /// Required: Yes
        /// Type: List of Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchSpecifications")]
        public Union<List<SpotFleetLaunchSpecification>, IntrinsicFunction> LaunchSpecifications { get; set; }

        /// <summary>
        /// ReplaceUnhealthyInstances
        /// Indicates whether the Spot fleet should replace unhealthy instances.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReplaceUnhealthyInstances")]
        public Union<bool, IntrinsicFunction> ReplaceUnhealthyInstances { get; set; }

        /// <summary>
        /// SpotPrice
        /// The bid price per unit hour. For more information, see How Spot Fleet Works in the Amazon EC2 User
        /// Guide for Linux Instances.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotPrice")]
        public Union<string, IntrinsicFunction> SpotPrice { get; set; }

        /// <summary>
        /// TargetCapacity
        /// The number of units to request for the spot fleet. You can choose to set the target capacity as the
        /// number of instances or as a performance characteristic that is important to your application
        /// workload, such as vCPUs, memory, or I/O. For more information, see How Spot Fleet Works in the
        /// Amazon EC2 User Guide for Linux Instances.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetCapacity")]
        public Union<int, IntrinsicFunction> TargetCapacity { get; set; }

        /// <summary>
        /// TerminateInstancesWithExpiration
        /// Indicates whether running Spot instances are terminated when the Spot fleet request expires.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TerminateInstancesWithExpiration")]
        public Union<bool, IntrinsicFunction> TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// Type
        /// The type of request, which indicates whether the fleet will only request the target capacity or also
        /// attempt to maintain it. For more information, see SpotFleetRequestConfigData in the Amazon EC2 API
        /// Reference.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ValidFrom
        /// The start date and time of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). By default, Amazon
        /// Elastic Compute Cloud (Amazon EC2 ) starts fulfilling the request immediately.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ValidFrom")]
        public Union<string, IntrinsicFunction> ValidFrom { get; set; }

        /// <summary>
        /// ValidUntil
        /// The end date and time of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). After the end date and
        /// time, Amazon EC2 doesn&#39;t request new Spot instances or enable them to fulfill the request.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ValidUntil")]
        public Union<string, IntrinsicFunction> ValidUntil { get; set; }

    }
}
