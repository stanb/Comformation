using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Lambda
    /// Calls an AWS Lambda function, passing in information about the detector model instance and the event which
    /// triggered the action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-lambda.html
    /// </summary>
    public class Lambda
    {

        /// <summary>
        /// FunctionArn
        /// The ARN of the AWS Lambda function which is executed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionArn")]
        public Union<string, IntrinsicFunction> FunctionArn { get; set; }

    }
}
