using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-as-mixedinstancespolicy-launchtemplate.html
    /// </summary>
    public class LaunchTemplate
    {

        /// <summary>
        /// LaunchTemplateSpecification
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// Overrides
        /// </summary>
        [JsonProperty("Overrides")]
        public List<LaunchTemplateOverrides> Overrides { get; set; }

    }
}
