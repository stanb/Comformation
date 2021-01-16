using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Lambda
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-lambda.html
    /// </summary>
    public class Lambda
    {

        /// <summary>
        /// FunctionArn
        /// The ARN of the Lambda function that is executed.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionArn")]
        public Union<string, IntrinsicFunction> FunctionArn { get; set; }

        /// <summary>
        /// Payload
        /// You can configure the action payload when you send a message to a Lambda function.
        /// Required: No
        /// Type: Payload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

    }
}
