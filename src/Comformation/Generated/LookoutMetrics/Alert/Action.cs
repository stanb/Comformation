using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.Alert
{
    /// <summary>
    /// AWS::LookoutMetrics::Alert Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-alert-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// SNSConfiguration
        /// A configuration for an Amazon SNS channel.
        /// Required: No
        /// Type: SNSConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SNSConfiguration")]
        public SNSConfiguration SNSConfiguration { get; set; }

        /// <summary>
        /// LambdaConfiguration
        /// A configuration for an AWS Lambda channel.
        /// Required: No
        /// Type: LambdaConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LambdaConfiguration")]
        public LambdaConfiguration LambdaConfiguration { get; set; }

    }
}
