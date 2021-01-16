using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate Placement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-placement.html
    /// </summary>
    public class Placement
    {

        /// <summary>
        /// GroupName
        /// The name of the placement group for the instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupName")]
        public Union<string, IntrinsicFunction> GroupName { get; set; }

        /// <summary>
        /// Tenancy
        /// The tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy 	of
        /// dedicated runs on single-tenant hardware.
        /// Required: No
        /// Type: String
        /// Allowed values: dedicated | default | host
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tenancy")]
        public Union<string, IntrinsicFunction> Tenancy { get; set; }

        /// <summary>
        /// SpreadDomain
        /// Reserved for future use.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpreadDomain")]
        public Union<string, IntrinsicFunction> SpreadDomain { get; set; }

        /// <summary>
        /// PartitionNumber
        /// The number of the partition the instance should launch in. Valid only if the placement group
        /// strategy is set to partition.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public Union<int, IntrinsicFunction> PartitionNumber { get; set; }

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone for the instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// Affinity
        /// The affinity setting for an instance on a Dedicated Host.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Affinity")]
        public Union<string, IntrinsicFunction> Affinity { get; set; }

        /// <summary>
        /// HostId
        /// The ID of the Dedicated Host for the instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostId")]
        public Union<string, IntrinsicFunction> HostId { get; set; }

        /// <summary>
        /// HostResourceGroupArn
        /// 	
        /// The ARN of the host resource group in which to launch the instances. If you specify a host
        /// 		resource group ARN, omit the Tenancy parameter 		or set it to host.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostResourceGroupArn")]
        public Union<string, IntrinsicFunction> HostResourceGroupArn { get; set; }

    }
}
