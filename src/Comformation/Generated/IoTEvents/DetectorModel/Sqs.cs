using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Sqs
    /// Sends information about the detector model instance and the event which triggered the action to an Amazon SQS
    /// queue.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html
    /// </summary>
    public class Sqs
    {

        /// <summary>
        /// UseBase64
        /// Set this to TRUE if you want the data to be Base-64 encoded before it is written to the queue.
        /// Otherwise, set this to FALSE.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseBase64")]
        public Union<bool, IntrinsicFunction> UseBase64 { get; set; }

        /// <summary>
        /// QueueUrl
        /// The URL of the Amazon SQS queue where the data is written.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueueUrl")]
        public Union<string, IntrinsicFunction> QueueUrl { get; set; }

    }
}
