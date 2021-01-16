using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis PortRange
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html
    /// </summary>
    public class PortRange
    {

        /// <summary>
        /// From
        /// 		
        /// The first port in the range.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("From")]
        public Union<int, IntrinsicFunction> From { get; set; }

        /// <summary>
        /// To
        /// 		
        /// The last port in the range.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("To")]
        public Union<int, IntrinsicFunction> To { get; set; }

    }
}
