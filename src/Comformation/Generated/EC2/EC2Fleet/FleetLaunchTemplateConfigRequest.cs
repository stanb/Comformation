using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet FleetLaunchTemplateConfigRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateconfigrequest.html
    /// </summary>
    public class FleetLaunchTemplateConfigRequest
    {

        /// <summary>
        /// LaunchTemplateSpecification
        /// The launch template to use. You must specify either the launch template ID or launch template name
        /// in the request.
        /// Required: No
        /// Type: FleetLaunchTemplateSpecificationRequest
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public FleetLaunchTemplateSpecificationRequest LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// Overrides
        /// Any parameters that you specify override the same parameters in the launch template.
        /// For fleets of type request and maintain, a maximum of 300 items is allowed across all launch
        /// templates.
        /// Required: No
        /// Type: List of FleetLaunchTemplateOverridesRequest
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Overrides")]
        public List<FleetLaunchTemplateOverridesRequest> Overrides { get; set; }

    }
}
