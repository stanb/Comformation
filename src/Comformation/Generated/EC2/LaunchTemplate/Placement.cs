using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate Placement
    /// The Placement property type specifies the placement for the instance in an Amazon EC2 launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html
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
        /// The tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of
        /// dedicated runs on single-tenant hardware.
        /// Valid values include default, dedicated, and host.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tenancy")]
        public Union<string, IntrinsicFunction> Tenancy { get; set; }

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

    }
}
