using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate CreditSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-creditspecification.html
    /// </summary>
    public class CreditSpecification
    {

        /// <summary>
        /// CpuCredits
        /// The credit option for CPU usage of a T2, T3, or T3a instance. Valid values are standard and
        /// unlimited.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CpuCredits")]
        public Union<string, IntrinsicFunction> CpuCredits { get; set; }

    }
}
