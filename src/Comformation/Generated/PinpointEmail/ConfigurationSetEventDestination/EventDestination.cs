using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination EventDestination
    /// In Amazon Pinpoint, events include message sends, deliveries, opens, clicks, bounces, and complaints. Event
    /// destinations are places that you can send information about these events to. For example, you can send event
    /// data to Amazon SNS to receive notifications when you receive bounces or complaints, or you can use Amazon
    /// Kinesis Data Firehose to stream data to Amazon S3 for long-term storage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html
    /// </summary>
    public class EventDestination
    {

        /// <summary>
        /// SnsDestination
        /// An object that defines an Amazon SNS destination for email events. You can use Amazon SNS to send
        /// notification when certain email events occur.
        /// Required: No
        /// Type: SnsDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnsDestination")]
        public SnsDestination SnsDestination { get; set; }

        /// <summary>
        /// CloudWatchDestination
        /// An object that defines an Amazon CloudWatch destination for email events. You can use Amazon
        /// CloudWatch to monitor and gain insights on your email sending metrics.
        /// Required: No
        /// Type: CloudWatchDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchDestination")]
        public CloudWatchDestination CloudWatchDestination { get; set; }

        /// <summary>
        /// Enabled
        /// If true, the event destination is enabled. When the event destination is enabled, the specified
        /// event types are sent to the destinations in this EventDestinationDefinition.
        /// If false, the event destination is disabled. When the event destination is disabled, events aren&#39;t
        /// sent to the specified destinations.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// MatchingEventTypes
        /// The types of events that Amazon Pinpoint sends to the specified event destinations. Acceptable
        /// values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, and RENDERING_FAILURE.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchingEventTypes")]
        public List<Union<string, IntrinsicFunction>> MatchingEventTypes { get; set; }

        /// <summary>
        /// PinpointDestination
        /// An object that defines a Amazon Pinpoint destination for email events. You can use Amazon Pinpoint
        /// events to create attributes in Amazon Pinpoint projects. You can use these attributes to create
        /// segments for your campaigns.
        /// Required: No
        /// Type: PinpointDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PinpointDestination")]
        public PinpointDestination PinpointDestination { get; set; }

        /// <summary>
        /// KinesisFirehoseDestination
        /// An object that defines an Amazon Kinesis Data Firehose destination for email events. You can use
        /// Amazon Kinesis Data Firehose to stream data to other services, such as Amazon S3 and Amazon
        /// Redshift.
        /// Required: No
        /// Type: KinesisFirehoseDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseDestination")]
        public KinesisFirehoseDestination KinesisFirehoseDestination { get; set; }

    }
}
