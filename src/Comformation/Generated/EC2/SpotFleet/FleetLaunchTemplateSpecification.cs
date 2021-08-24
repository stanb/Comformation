using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet FleetLaunchTemplateSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html
    /// </summary>
    public class FleetLaunchTemplateSpecification
    {

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template. If you specify the template ID, you can&#39;t specify the template name.
        /// Required: Conditional
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template. You must specify either a template name or a template ID.
        /// Minimum length of 3. Maximum length of 128. Names must match the following pattern: [a-zA-Z0-9\(\)\.
        /// -/_]+
        /// Required: Conditional
        /// Type: String
        /// Minimum: 3
        /// Maximum: 128
        /// Pattern: [a-zA-Z0-9\(\)\. \-/_]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// Version
        /// The version number of the launch template. You must specify a version number. AWS CloudFormation
        /// does not support specifying $Latest or $Default for the template version number.
        /// Minimum length of 1. Maximum length of 255. Versions must fit the following pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
