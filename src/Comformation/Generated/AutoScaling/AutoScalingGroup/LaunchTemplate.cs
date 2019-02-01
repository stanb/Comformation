using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup LaunchTemplate
    /// The LaunchTemplate property type describes a launch template and overrides.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplate.html
    /// </summary>
    public class LaunchTemplate
    {

        /// <summary>
        /// LaunchTemplateSpecification
        /// The launch template to use. You must specify either the launch template ID or launch template name
        /// in the request.
        /// Required: Yes
        /// Type: LaunchTemplateSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// Overrides
        /// Any parameters that you specify override the same parameters in the launch template. Currently, the
        /// only supported override is instance type.
        /// You must specify between 2 and 20 overrides.
        /// Required: Yes
        /// Type: List of LaunchTemplateOverrides property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public List<LaunchTemplateOverrides> Overrides { get; set; }

    }
}
