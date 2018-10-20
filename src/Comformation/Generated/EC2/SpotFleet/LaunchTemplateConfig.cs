using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet LaunchTemplateConfig
    /// LaunchTemplateConfig is a property of the Amazon EC2 SpotFleet SpotFleetRequestConfigData property that
    /// describes a launch template and overrides.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html
    /// </summary>
    public class LaunchTemplateConfig
    {

        /// <summary>
        /// LaunchTemplateSpecification
        /// The launch template.
        /// Required: Yes
        /// Type: Amazon EC2 SpotFleet FleetLaunchTemplateSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public FleetLaunchTemplateSpecification LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// Overrides
        /// Any parameters that you specify override the same parameters in the launch template.
        /// Required: No
        /// Type: List of Amazon EC2 SpotFleet LaunchTemplateOverrides
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public List<LaunchTemplateOverrides> Overrides { get; set; }

    }
}
