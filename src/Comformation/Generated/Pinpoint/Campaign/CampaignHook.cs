using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign CampaignHook
    /// Specifies the AWS Lambda function to use as a code hook for a campaign.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html
    /// </summary>
    public class CampaignHook
    {

        /// <summary>
        /// Mode
        /// Specifies which Lambda mode to use when invoking the AWS Lambda function.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// WebUrl
        /// The web URL that Amazon Pinpoint calls to invoke the AWS Lambda function over HTTPS.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WebUrl")]
        public Union<string, IntrinsicFunction> WebUrl { get; set; }

        /// <summary>
        /// LambdaFunctionName
        /// The name or Amazon Resource Name (ARN) of the AWS Lambda function that Amazon Pinpoint invokes to
        /// send messages for a campaign.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionName")]
        public Union<string, IntrinsicFunction> LambdaFunctionName { get; set; }

    }
}
