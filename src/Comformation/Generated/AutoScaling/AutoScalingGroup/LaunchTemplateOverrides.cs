using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LaunchTemplateOverrides
    /// LaunchTemplateOverrides is a subproperty of LaunchTemplate that describes an override for a launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html
    /// </summary>
    public class LaunchTemplateOverrides
    {

        /// <summary>
        /// InstanceType
        /// The instance type. For more information, see Available Instance Types in the Amazon EC2 User Guide
        /// for Linux Instances.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
