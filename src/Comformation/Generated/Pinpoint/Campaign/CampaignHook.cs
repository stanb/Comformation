using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign CampaignHook
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html
    /// </summary>
    public class CampaignHook
    {

        /// <summary>
        /// Mode
        /// The mode that Amazon Pinpoint uses to invoke the AWS Lambda function. Possible values are:
        /// FILTER - Invoke the function to customize the segment that&#39;s used by a campaign. DELIVERY -
        /// (Deprecated) Previously, invoked the function to send a campaign through a custom channel. This
        /// functionality is not supported anymore. To send a campaign through a custom channel, use the
        /// CustomDeliveryConfiguration and CampaignCustomMessage objects of the campaign.
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
        /// customize a segment for a campaign.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionName")]
        public Union<string, IntrinsicFunction> LambdaFunctionName { get; set; }

    }
}
