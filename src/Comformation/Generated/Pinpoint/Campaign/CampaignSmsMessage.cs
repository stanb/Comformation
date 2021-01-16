using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign CampaignSmsMessage
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
        /// The SMS message type. Valid values are TRANSACTIONAL (for messages that are critical or
        /// time-sensitive, such as a one-time passwords) and PROMOTIONAL (for messsages that aren&#39;t critical or
        /// time-sensitive, such as marketing messages).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageType")]
        public Union<string, IntrinsicFunction> MessageType { get; set; }

    }
}
