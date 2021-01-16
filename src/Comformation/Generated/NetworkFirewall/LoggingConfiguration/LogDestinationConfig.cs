using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.LoggingConfiguration
{
    /// <summary>
    /// AWS::NetworkFirewall::LoggingConfiguration LogDestinationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfig.html
    /// </summary>
    public class LogDestinationConfig
    {

        /// <summary>
        /// LogType
        /// The type of log to send. Alert logs report traffic that matches a stateful rule with an action
        /// setting that sends an alert log message. Flow logs are standard network traffic flow logs.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALERT | FLOW
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogType")]
        public Union<string, IntrinsicFunction> LogType { get; set; }

        /// <summary>
        /// LogDestinationType
        /// The type of storage destination to send these logs to. You can send logs to an Amazon S3 bucket, a
        /// CloudWatch log group, or a Kinesis Data Firehose delivery stream.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CloudWatchLogs | KinesisDataFirehose | S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogDestinationType")]
        public Union<string, IntrinsicFunction> LogDestinationType { get; set; }

        /// <summary>
        /// LogDestination
        /// The named location for the logs, provided in a key:value mapping that is specific to the chosen
        /// destination type.
        /// For an Amazon S3 bucket, provide the name of the bucket, with key bucketName, and optionally provide
        /// a prefix, with key prefix. The following example specifies an Amazon S3 bucket named
        /// DOC-EXAMPLE-BUCKET and the prefix alerts: &quot;LogDestination&quot;: { &quot;bucketName&quot;: &quot;DOC-EXAMPLE-BUCKET&quot;,
        /// &quot;prefix&quot;: &quot;alerts&quot; } For a CloudWatch log group, provide the name of the CloudWatch log group, with
        /// key logGroup. The following example specifies a log group named alert-log-group: &quot;LogDestination&quot;: {
        /// &quot;logGroup&quot;: &quot;alert-log-group&quot; } For a Kinesis Data Firehose delivery stream, provide the name of the
        /// delivery stream, with key deliveryStream. The following example specifies a delivery stream named
        /// alert-delivery-stream: &quot;LogDestination&quot;: { &quot;deliveryStream&quot;: &quot;alert-delivery-stream&quot; }
        /// Required: Yes
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogDestination")]
        public Dictionary<string, Union<string, IntrinsicFunction>> LogDestination { get; set; }

    }
}
