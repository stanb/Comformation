using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet FleetLaunchTemplateSpecification
    /// FleetLaunchTemplateSpecification is a property of the Amazon EC2 SpotFleet SpotFleetRequestConfigData property
    /// that describes a launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html
    /// </summary>
    public class FleetLaunchTemplateSpecification
    {

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template. You must specify either a template ID or a template name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template. You must specify either a template name or a template ID.
        /// Minimum length of 3. Maximum length of 128. Names must match the following pattern: [a-zA-Z0-9\(\)\.
        /// -/_]+
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// Version
        /// The version number. By default, the default version of the launch template is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
