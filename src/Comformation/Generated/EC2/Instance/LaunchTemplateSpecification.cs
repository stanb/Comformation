using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon EC2 Instance LaunchTemplateSpecification
    /// The LaunchTemplateSpecification property type specifies the launch template to use. You must specify either
    /// the launch template ID or launch template name.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-launchtemplatespecification.html
    /// </summary>
    public class LaunchTemplateSpecification
    {

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template. You must specify either a template ID or a template name.
        /// Minimum length of 1. Maximum length of 255. IDs must fit the following pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template. You must specify either a template name or a template ID.
        /// Minimum length of 3. Maximum length of 128. Names must fit the following pattern:
        /// [a-zA-Z0-9\(\)\. -/_]+
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// Version
        /// The version number. AWS CloudFormation does not support specifying $Latest, or $Default for the
        /// template version number.
        /// Minimum length of 1. Maximum length of 255. Versions must fit the following pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
