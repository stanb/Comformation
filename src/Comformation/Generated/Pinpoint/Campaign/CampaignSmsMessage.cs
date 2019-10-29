using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign CampaignSmsMessage
    /// Specifies the content and settings for an SMS message that&#39;s sent to recipients of a campaign.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html
    /// </summary>
    public class CampaignSmsMessage
    {

        /// <summary>
        /// SenderId
        /// The sender ID to display on recipients&#39; devices when they receive the SMS message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SenderId")]
        public Union<string, IntrinsicFunction> SenderId { get; set; }

        /// <summary>
        /// Body
        /// The body of the SMS message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Body")]
        public Union<string, IntrinsicFunction> Body { get; set; }

        /// <summary>
        /// MessageType
        /// The type of SMS message. Valid values are: TRANSACTIONAL, the message is critical or time-sensitive,
        /// such as a one-time password that supports a customer transaction; and, PROMOTIONAL, the message
        /// isn&#39;t critical or time-sensitive, such as a marketing message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageType")]
        public Union<string, IntrinsicFunction> MessageType { get; set; }

    }
}
