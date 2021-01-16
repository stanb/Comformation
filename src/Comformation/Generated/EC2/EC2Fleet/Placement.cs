using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet Placement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html
    /// </summary>
    public class Placement
    {

        /// <summary>
        /// GroupName
        /// The name of the placement group the instance is in.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupName")]
        public Union<string, IntrinsicFunction> GroupName { get; set; }

        /// <summary>
        /// Tenancy
        /// The tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of
        /// dedicated runs on single-tenant hardware. The host tenancy is not supported for the ImportInstance
        /// command.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: String
        /// Allowed values: dedicated | default | host
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tenancy")]
        public Union<string, IntrinsicFunction> Tenancy { get; set; }

        /// <summary>
        /// SpreadDomain
        /// Reserved for future use.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpreadDomain")]
        public Union<string, IntrinsicFunction> SpreadDomain { get; set; }

        /// <summary>
        /// PartitionNumber
        /// The number of the partition the instance is in. Valid only if the placement group strategy is set to
        /// partition.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public Union<int, IntrinsicFunction> PartitionNumber { get; set; }

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone of the instance.
        /// If not specified, an Availability Zone will be automatically chosen for you based on the load
        /// balancing criteria for the Region.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// Affinity
        /// The affinity setting for the instance on the Dedicated Host. This parameter is not supported for the
        /// ImportInstance command.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Affinity")]
        public Union<string, IntrinsicFunction> Affinity { get; set; }

        /// <summary>
        /// HostId
        /// The ID of the Dedicated Host on which the instance resides. This parameter is not supported for the
        /// ImportInstance command.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HostId")]
        public Union<string, IntrinsicFunction> HostId { get; set; }

        /// <summary>
        /// HostResourceGroupArn
        /// 	
        /// The ARN of the host resource group in which to launch the instances. If you specify 		a host
        /// resource group ARN, omit the Tenancy 		parameter or set it to host.
        /// This parameter is not supported by CreateFleet.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HostResourceGroupArn")]
        public Union<string, IntrinsicFunction> HostResourceGroupArn { get; set; }

    }
}
