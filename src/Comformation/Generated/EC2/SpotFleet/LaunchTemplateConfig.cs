using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html
    /// </summary>
    public class LaunchTemplateConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html#cfn-ec2-spotfleet-launchtemplateconfig-launchtemplatespecification
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public Union<FleetLaunchTemplateSpecification, IntrinsicFunction> LaunchTemplateSpecification { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html#cfn-ec2-spotfleet-launchtemplateconfig-overrides
        /// </summary>
        [JsonProperty("Overrides")]
        public Union<List<LaunchTemplateOverrides>, IntrinsicFunction> Overrides { get; set; }

    }
}
