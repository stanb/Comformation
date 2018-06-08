using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate CreditSpecification
    /// The CreditSpecification property type specifies the credit option for CPU usage of a T2 instance for an Amazon
    /// EC2 launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-creditspecification.html
    /// </summary>
    public class CreditSpecification
    {

        /// <summary>
        /// CpuCredits
        /// The credit option for CPU usage of a T2 instance. Valid values include standard and unlimited.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CpuCredits")]
        public Union<string, IntrinsicFunction> CpuCredits { get; set; }

    }
}
