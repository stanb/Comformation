using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet Placement
    /// Placement is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications property that
    /// defines the placement group for the Spot instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-placement.html
    /// </summary>
    public class SpotPlacement
    {

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone (AZ) of the placement group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// GroupName
        /// The name of the placement group (for cluster instances).
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
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tenancy")]
        public Union<string, IntrinsicFunction> Tenancy { get; set; }

    }
}
