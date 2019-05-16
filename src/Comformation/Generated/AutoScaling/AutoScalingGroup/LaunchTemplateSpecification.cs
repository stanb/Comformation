using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LaunchTemplateSpecification
    /// LaunchTemplateSpecification is a property of AutoScalingGroup that specifies the launch template to use to
    /// launch instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html
    /// </summary>
    public class LaunchTemplateSpecification
    {

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template. You must specify either a template ID or a template name.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template. You must specify either a template name or a template ID.
        /// Required: Conditional
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
        /// The version number. AWS CloudFormation does not support specifying $Latest, or $Default for the
        /// template version number.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
