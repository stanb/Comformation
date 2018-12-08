using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon Elastic Compute Cloud Instance LicenseSpecification
    /// The LicenseSpecification property type associates a license configuration with an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-licensespecification.html
    /// </summary>
    public class LicenseSpecification
    {

        /// <summary>
        /// LicenseConfigurationArn
        /// The Amazon Resource Name (ARN) of license configuration to associate with the instance.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LicenseConfigurationArn")]
        public Union<string, IntrinsicFunction> LicenseConfigurationArn { get; set; }

    }
}
