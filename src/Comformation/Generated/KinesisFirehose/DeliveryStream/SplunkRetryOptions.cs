using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream SplunkRetryOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkretryoptions.html
    /// </summary>
    public class SplunkRetryOptions
    {

        /// <summary>
        /// DurationInSeconds
        /// The total amount of time that Kinesis Data Firehose spends on retries. This duration starts after
        /// the initial attempt to send data to Splunk fails. It doesn&#39;t include the periods during which
        /// Kinesis Data Firehose waits for acknowledgment from Splunk after each attempt.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 7200
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationInSeconds")]
        public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

    }
}
