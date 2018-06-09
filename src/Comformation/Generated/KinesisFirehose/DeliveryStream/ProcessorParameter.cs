using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream ProcessorParameter
    /// The ProcessorParameter property specifies a processor parameter in a data processor for an Amazon Kinesis
    /// Firehose delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processorparameter.html
    /// </summary>
    public class ProcessorParameter
    {

        /// <summary>
        /// ParameterName
        /// The name of the parameter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterName")]
        public Union<string, IntrinsicFunction> ParameterName { get; set; }

        /// <summary>
        /// ParameterValue
        /// The parameter value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterValue")]
        public Union<string, IntrinsicFunction> ParameterValue { get; set; }

    }
}
