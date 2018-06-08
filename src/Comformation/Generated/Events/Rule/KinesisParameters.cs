using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Amazon CloudWatch Events Rule KinesisParameters
    /// The KinesisParameters property type specifies settings that control shard assignment for a Kinesis stream
    /// target.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-kinesisparameters.html
    /// </summary>
    public class KinesisParameters
    {

        /// <summary>
        /// PartitionKeyPath
        /// The JSON path to extract from the event and use as the partition key. The default is to use the
        /// eventId as the partition key. For more information, see Amazon Kinesis Streams Key Concepts in the
        /// Kinesis Streams Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionKeyPath")]
        public Union<string, IntrinsicFunction> PartitionKeyPath { get; set; }

    }
}
