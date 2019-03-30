using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-licensespecification.html
    /// </summary>
    public class LicenseSpecification
    {

        /// <summary>
        /// LicenseConfigurationArn
        /// </summary>
        [JsonProperty("LicenseConfigurationArn")]
        public Union<string, IntrinsicFunction> LicenseConfigurationArn { get; set; }

    }
}
