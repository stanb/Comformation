using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet SpotFleetTagSpecification
    /// SpotFleetTagSpecification is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications
    /// property that specifies the tags for a Spot fleet resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-tagspecifications.html
    /// </summary>
    public class SpotFleetTagSpecification
    {

        /// <summary>
        /// ResourceType
        /// The type of resource.
        /// For valid resource types, see SpotFleetTagSpecification operation in the Amazon EC2 API Reference
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

    }
}
