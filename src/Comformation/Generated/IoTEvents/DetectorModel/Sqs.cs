using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Sqs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html
    /// </summary>
    public class Sqs
    {

        /// <summary>
        /// Payload
        /// You can configure the action payload when you send a message to an Amazon SQS queue.
        /// Required: No
        /// Type: Payload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

        /// <summary>
        /// QueueUrl
        /// The URL of the SQS queue where the data is written.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueueUrl")]
        public Union<string, IntrinsicFunction> QueueUrl { get; set; }

        /// <summary>
        /// UseBase64
        /// Set this to TRUE if you want the data to be base-64 encoded before it is written to the queue.
        /// Otherwise, set this to FALSE.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseBase64")]
        public Union<bool, IntrinsicFunction> UseBase64 { get; set; }

    }
}
