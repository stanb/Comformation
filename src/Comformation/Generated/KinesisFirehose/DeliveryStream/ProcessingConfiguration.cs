using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream ProcessingConfiguration
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
        /// Required: No
        /// Type: List of Processor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Processors")]
        public List<Processor> Processors { get; set; }

    }
}
