using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector AppFlowConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-appflowconfig.html
    /// </summary>
    public class AppFlowConfig
    {

        /// <summary>
        /// RoleArn
        /// An IAM role that gives Amazon Lookout for Metrics permission to access the flow.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// FlowName
        /// name of the flow.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FlowName")]
        public Union<string, IntrinsicFunction> FlowName { get; set; }

    }
}
