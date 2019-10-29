using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign MessageConfiguration
    /// Specifies the message configuration settings for a campaign.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html
    /// </summary>
    public class MessageConfiguration
    {

        /// <summary>
        /// APNSMessage
        /// The message that the campaign sends through the APNs (Apple Push Notification service) channel. This
        /// message overrides the default message.
        /// Required: No
        /// Type: Message
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("APNSMessage")]
        public Message APNSMessage { get; set; }

        /// <summary>
        /// BaiduMessage
        /// The message that the campaign sends through the Baidu (Baidu Cloud Push) channel. This message
        /// overrides the default message.
        /// Required: No
        /// Type: Message
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaiduMessage")]
        public Message BaiduMessage { get; set; }

        /// <summary>
        /// DefaultMessage
        /// The default message that the campaign sends through all the channels that are configured for the
        /// campaign.
        /// Required: No
        /// Type: Message
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultMessage")]
        public Message DefaultMessage { get; set; }

        /// <summary>
        /// EmailMessage
        /// The message that the campaign sends through the email channel.
        /// Required: No
        /// Type: CampaignEmailMessage
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmailMessage")]
        public CampaignEmailMessage EmailMessage { get; set; }

        /// <summary>
        /// GCMMessage
        /// The message that the campaign sends through the GCM channel, which enables Amazon Pinpoint to send
        /// push notifications through the Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging
        /// (GCM), service. This message overrides the default message.
        /// Required: No
        /// Type: Message
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GCMMessage")]
        public Message GCMMessage { get; set; }

        /// <summary>
        /// SMSMessage
        /// The message that the campaign sends through the SMS channel.
        /// Required: No
        /// Type: CampaignSmsMessage
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SMSMessage")]
        public CampaignSmsMessage SMSMessage { get; set; }

        /// <summary>
        /// ADMMessage
        /// The message that the campaign sends through the ADM (Amazon Device Messaging) channel. This message
        /// overrides the default message.
        /// Required: No
        /// Type: Message
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ADMMessage")]
        public Message ADMMessage { get; set; }

    }
}
