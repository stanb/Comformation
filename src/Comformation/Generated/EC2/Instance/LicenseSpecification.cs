using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance LicenseSpecification
    /// Specifies the license configuration to use.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-licensespecification.html
    /// </summary>
    public class LicenseSpecification
    {

        /// <summary>
        /// LicenseConfigurationArn
        /// The Amazon Resource Name (ARN) of the license configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LicenseConfigurationArn")]
        public Union<string, IntrinsicFunction> LicenseConfigurationArn { get; set; }

    }
}
