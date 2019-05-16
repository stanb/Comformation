using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate LicenseSpecification
    /// Specifies a license configuration for an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-licensespecification.html
    /// </summary>
    public class LicenseSpecification
    {

        /// <summary>
        /// LicenseConfigurationArn
        /// The Amazon Resource Name (ARN) of the license configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LicenseConfigurationArn")]
        public Union<string, IntrinsicFunction> LicenseConfigurationArn { get; set; }

    }
}
