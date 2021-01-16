using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet SpotPlacement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-placement.html
    /// </summary>
    public class SpotPlacement
    {

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone.
        /// To specify multiple Availability Zones, separate them using commas; for example, &quot;us-west-2a,
        /// us-west-2b&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// GroupName
        /// The name of the placement group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupName")]
        public Union<string, IntrinsicFunction> GroupName { get; set; }

        /// <summary>
        /// Tenancy
        /// The tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of
        /// dedicated runs on single-tenant hardware. The host tenancy is not supported for Spot Instances.
        /// Required: No
        /// Type: String
        /// Allowed values: dedicated | default | host
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tenancy")]
        public Union<string, IntrinsicFunction> Tenancy { get; set; }

    }
}
