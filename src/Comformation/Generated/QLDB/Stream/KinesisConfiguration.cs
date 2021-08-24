using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QLDB.Stream
{
    /// <summary>
    /// AWS::QLDB::Stream KinesisConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qldb-stream-kinesisconfiguration.html
    /// </summary>
    public class KinesisConfiguration
    {

        /// <summary>
        /// StreamArn
        /// The Amazon Resource Name (ARN) of the Kinesis Data Streams resource.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 1600
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StreamArn")]
        public Union<string, IntrinsicFunction> StreamArn { get; set; }

        /// <summary>
        /// AggregationEnabled
        /// Enables QLDB to publish multiple data records in a single Kinesis Data Streams record, increasing
        /// the number of records sent per API call.
        /// This option is enabled by default. Record aggregation has important implications for processing
        /// records and requires de-aggregation in your stream consumer. To learn more, see KPL Key Concepts and
        /// Consumer De-aggregation in the Amazon Kinesis Data Streams Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AggregationEnabled")]
        public Union<bool, IntrinsicFunction> AggregationEnabled { get; set; }

    }
}
