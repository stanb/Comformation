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
        /// EntityId
        /// The entity ID or Principal Entity (PE) id received from the regulatory body for sending SMS in your
        /// country.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntityId")]
        public Union<string, IntrinsicFunction> EntityId { get; set; }

        /// <summary>
        /// OriginationNumber
        /// The long code to send the SMS message from. This value should be one of the dedicated long codes
        /// that&#39;s assigned to your AWS account. Although it isn&#39;t required, we recommend that you specify the
        /// long code using an E. 164 format to ensure prompt and accurate delivery of the message. For example,
        /// +12065550100.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginationNumber")]
        public Union<string, IntrinsicFunction> OriginationNumber { get; set; }

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

        /// <summary>
        /// TemplateId
        /// The template ID received from the regulatory body for sending SMS in your country.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemplateId")]
        public Union<string, IntrinsicFunction> TemplateId { get; set; }

    }
}
