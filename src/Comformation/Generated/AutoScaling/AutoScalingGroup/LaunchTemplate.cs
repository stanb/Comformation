using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LaunchTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplate.html
    /// </summary>
    public class LaunchTemplate
    {

        /// <summary>
        /// LaunchTemplateSpecification
        /// The EC2 launch template to use.
        /// Required: Yes
        /// Type: LaunchTemplateSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// Overrides
        /// Any properties that you specify override the same properties in the launch template. The maximum
        /// number of instance types that can be associated with an Auto Scaling group is 40. The maximum number
        /// of distinct launch templates you can define for an Auto Scaling group is 20. For more information
        /// about configuring overrides, see Configuring overrides in the Amazon EC2 Auto Scaling User Guide.
        /// If not provided, Amazon EC2 Auto Scaling will use the instance type specified in the launch template
        /// to launch instances.
        /// Required: No
        /// Type: List of LaunchTemplateOverrides
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public List<LaunchTemplateOverrides> Overrides { get; set; }

    }
}
