using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet LaunchTemplateConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html
    /// </summary>
    public class LaunchTemplateConfig
    {

        /// <summary>
        /// LaunchTemplateSpecification
        /// The launch template.
        /// Required: No
        /// Type: FleetLaunchTemplateSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public FleetLaunchTemplateSpecification LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// Overrides
        /// Any parameters that you specify override the same parameters in the launch template.
        /// Required: No
        /// Type: List of LaunchTemplateOverrides
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public List<LaunchTemplateOverrides> Overrides { get; set; }

    }
}
