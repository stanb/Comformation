using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance CreditSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-creditspecification.html
    /// </summary>
    public class CreditSpecification
    {

        /// <summary>
        /// CPUCredits
        /// 		
        /// The credit option for CPU usage of the instance. Valid values are 			standard and unlimited. T3
        /// instances 			launch as unlimited by default. T2 instances launch as 			standard by default.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CPUCredits")]
        public Union<string, IntrinsicFunction> CPUCredits { get; set; }

    }
}
