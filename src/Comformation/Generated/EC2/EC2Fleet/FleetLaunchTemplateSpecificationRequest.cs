using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet FleetLaunchTemplateSpecificationRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest.html
    /// </summary>
    public class FleetLaunchTemplateSpecificationRequest
    {

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template. If you specify the template name, you can&#39;t specify the template
        /// ID.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 128
        /// Pattern: [a-zA-Z0-9\(\)\. \-/_]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template. If you specify the template ID, you can&#39;t specify the template name.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// Version
        /// The launch template version number, $Latest, or $Default. You must specify a value, otherwise the
        /// request fails.
        /// If the value is $Latest, Amazon EC2 uses the latest version of the launch template.
        /// If the value is $Default, Amazon EC2 uses the default version of the launch template.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
