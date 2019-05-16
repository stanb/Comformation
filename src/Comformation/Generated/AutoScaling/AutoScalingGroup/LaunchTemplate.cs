using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LaunchTemplate
    /// LaunchTemplate is a subproperty of MixedInstancesPolicy that describes a launch template and overrides. The
    /// overrides are used to override the instance type specified by the launch template with multiple instance types
    /// that can be used to launch On-Demand Instances and Spot Instances.
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
        /// Any properties that you specify override the same properties in the launch template. Currently, the
        /// only supported override is instance type.
        /// You must specify between 2 and 20 overrides.
        /// Required: No
        /// Type: List of LaunchTemplateOverrides
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public List<LaunchTemplateOverrides> Overrides { get; set; }

    }
}
