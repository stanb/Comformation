using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::SES::ConfigurationSetEventDestination EventDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html
    /// </summary>
    public class EventDestination
    {

        /// <summary>
        /// CloudWatchDestination
        /// An object that contains the names, default values, and sources of the dimensions associated with an
        /// Amazon CloudWatch event destination.
        /// Required: No
        /// Type: CloudWatchDestination
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
        /// send - The call was successful and Amazon SES is attempting to deliver the email. reject - Amazon
        /// SES determined that the email contained a virus and rejected it. bounce - The recipient&#39;s mail
        /// server permanently rejected the email. This corresponds to a hard bounce. complaint - The recipient
        /// marked the email as spam. delivery - Amazon SES successfully delivered the email to the recipient&#39;s
        /// mail server. open - The recipient received the email and opened it in their email client. click -
        /// The recipient clicked one or more links in the email. renderingFailure - Amazon SES did not send the
        /// email because of a template rendering issue.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchingEventTypes")]
        public List<Union<string, IntrinsicFunction>> MatchingEventTypes { get; set; }

        /// <summary>
        /// Name
        /// The name of the event destination. The name must meet the following requirements:
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain 64
        /// characters or fewer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// KinesisFirehoseDestination
        /// An object that contains the delivery stream ARN and the IAM role ARN associated with an Amazon
        /// Kinesis Firehose event destination.
        /// Required: No
        /// Type: KinesisFirehoseDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseDestination")]
        public KinesisFirehoseDestination KinesisFirehoseDestination { get; set; }

    }
}
