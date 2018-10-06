using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// Amazon Simple Email Service ConfigurationSetEventDestination EventDestination
    /// For an Amazon SES configuration set event destination, the EventDestination property type specifies
    /// information about the event destination that the specified email sending events will be published to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html
    /// </summary>
    public class EventDestination
    {

        /// <summary>
        /// CloudWatchDestination
        /// The names, default values, and sources of the dimensions associated with an CloudWatch event
        /// destination.
        /// Required: No
        /// Type: Amazon SES ConfigurationSetEventDestination CloudWatchDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchDestination")]
        public CloudWatchDestination CloudWatchDestination { get; set; }

        /// <summary>
        /// Enabled
        /// Sets whether Amazon SES publishes events to this destination when you send an email with the
        /// associated configuration set. Set to true to enable publishing to this destination; set to false to
        /// prevent publishing to this destination. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// MatchingEventTypes
        /// The type of email sending events to publish to the event destination.
        /// For a list of valid values, see EventDestination in the Amazon Simple Email Service API Reference.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchingEventTypes")]
        public List<Union<string, IntrinsicFunction>> MatchingEventTypes { get; set; }

        /// <summary>
        /// Name
        /// The name of the event destination. The name can:
        /// Contain ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain up to 64
        /// characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// KinesisFirehoseDestination
        /// Contains the delivery stream ARN and the IAM role ARN associated with an Kinesis Data Firehose event
        /// destination.
        /// Required: No
        /// Type: Amazon SES ConfigurationSetEventDestination KinesisFirehoseDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseDestination")]
        public KinesisFirehoseDestination KinesisFirehoseDestination { get; set; }

    }
}
