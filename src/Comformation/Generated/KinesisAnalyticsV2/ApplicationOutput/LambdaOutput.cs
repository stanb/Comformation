using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput LambdaOutput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-lambdaoutput.html
    /// </summary>
    public class LambdaOutput
    {

        /// <summary>
        /// ResourceARN
        /// The Amazon Resource Name (ARN) of the destination Lambda function to write to.
        /// Note To specify an earlier version of the Lambda function than the latest, include the Lambda
        /// function version in the Lambda function ARN. For more information about Lambda ARNs, see Example
        /// ARNs: Amazon Lambda
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

    }
}
