using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream Processor
    /// The Processor property specifies a data processor for an Amazon Kinesis Data Firehose delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processor.html
    /// </summary>
    public class Processor
    {

        /// <summary>
        /// Parameters
        /// The processor parameters.
        /// Required: Yes
        /// Type: List of ProcessorParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public List<ProcessorParameter> Parameters { get; set; }

        /// <summary>
        /// Type
        /// The type of processor. Valid values: Lambda.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Lambda
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
