using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream Processor
    /// The Processor property specifies a data processor for an Amazon Kinesis Data Firehose delivery stream.
    /// Processor is a property of the Amazon Kinesis Data Firehose DeliveryStream ProcessingConfiguration property
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processor.html
    /// </summary>
    public class Processor
    {

        /// <summary>
        /// Parameters
        /// The processor parameters.
        /// Required: Yes
        /// Type: List of Amazon Kinesis Data Firehose DeliveryStream ProcessorParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public List<ProcessorParameter> Parameters { get; set; }

        /// <summary>
        /// Type
        /// The type of processor. Valid values: Lambda.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
