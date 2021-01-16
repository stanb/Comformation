using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream RetryOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-retryoptions.html
    /// </summary>
    public class RetryOptions
    {

        /// <summary>
        /// DurationInSeconds
        /// The total amount of time that Kinesis Data Firehose spends on retries. This duration starts after
        /// the initial attempt to send data to the custom destination via HTTPS endpoint fails. It doesn&#39;t
        /// include the periods during which Kinesis Data Firehose waits for acknowledgment from the specified
        /// destination after each attempt.
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
