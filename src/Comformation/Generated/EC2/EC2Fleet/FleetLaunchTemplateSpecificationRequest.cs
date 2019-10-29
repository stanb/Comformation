using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet FleetLaunchTemplateSpecificationRequest
    /// Specifies the launch template to use for an EC2 Fleet. You must specify either the launch template ID or
    /// launch template name in the request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest.html
    /// </summary>
    public class FleetLaunchTemplateSpecificationRequest
    {

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 128
        /// Pattern: [a-zA-Z0-9\(\)\. \-/_]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// Version
        /// The version number of the launch template. Note: This is a required parameter and will be updated
        /// soon.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

    }
}
