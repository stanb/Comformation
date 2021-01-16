using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream RedshiftRetryOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftretryoptions.html
    /// </summary>
    public class RedshiftRetryOptions
    {

        /// <summary>
        /// DurationInSeconds
        /// The length of time during which Kinesis Data Firehose retries delivery after a failure, starting
        /// from the initial request and including the first attempt. The default value is 3600 seconds (60
        /// minutes). Kinesis Data Firehose does not retry if the value of DurationInSeconds is 0 (zero) or if
        /// the first delivery attempt takes longer than the current value.
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
