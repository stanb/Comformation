using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup LaunchTemplateOverrides
    /// The LaunchTemplateOverrides property type describes an override for a launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html
    /// </summary>
    public class LaunchTemplateOverrides
    {

        /// <summary>
        /// InstanceType
        /// The instance type.
        /// For information about available instance types, see Available Instance Types in the Amazon EC2 User
        /// Guide for Linux Instances.
        /// Required: No
        /// Type: String
        /// Length constraints: Minimum length of 1. Maximum length of 255.
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
