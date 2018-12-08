using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon EC2 Instance CreditSpecification
    /// The CreditSpecification property type specifies the credit option for CPU usage of a T2 or T3 instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-creditspecification.html
    /// </summary>
    public class CreditSpecification
    {

        /// <summary>
        /// CPUCredits
        /// The credit option for CPU usage of a T2 or T3 instance. Valid values are unlimited and standard. T3
        /// instances launch as unlimited by default. T2 instances launch as standard by default.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CPUCredits")]
        public Union<string, IntrinsicFunction> CPUCredits { get; set; }

    }
}
