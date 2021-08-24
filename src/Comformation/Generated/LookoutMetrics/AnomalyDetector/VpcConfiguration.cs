using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector VpcConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-vpcconfiguration.html
    /// </summary>
    public class VpcConfiguration
    {

        /// <summary>
        /// SubnetIdList
        /// An array of strings containing the Amazon VPC subnet IDs (e. g. , subnet-0bb1c79de3EXAMPLE.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIdList")]
        public List<Union<string, IntrinsicFunction>> SubnetIdList { get; set; }

        /// <summary>
        /// SecurityGroupIdList
        /// An array of strings containing the list of security groups.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIdList { get; set; }

    }
}
