using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream ProcessingConfiguration
    /// The ProcessingConfiguration property configures data processing for an Amazon Kinesis Firehose delivery
    /// stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processingconfiguration.html
    /// </summary>
    public class ProcessingConfiguration
    {

        /// <summary>
        /// Enabled
        /// Indicates whether data processing is enabled (true) or disabled (false).
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Processors
        /// The data processors.
        /// Required: Yes
        /// Type: List of Kinesis Firehose DeliveryStream Processor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Processors")]
        public Union<List<Processor>, IntrinsicFunction> Processors { get; set; }

    }
}
