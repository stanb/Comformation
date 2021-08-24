using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule KinesisParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-kinesisparameters.html
    /// </summary>
    public class KinesisParameters
    {

        /// <summary>
        /// PartitionKeyPath
        /// The JSON path to be extracted from the event and used as the partition key. For more information,
        /// see Amazon Kinesis Streams Key Concepts in the Amazon Kinesis Streams Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionKeyPath")]
        public Union<string, IntrinsicFunction> PartitionKeyPath { get; set; }

    }
}
