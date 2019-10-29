using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Sns
    /// Sends an Amazon SNS message.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sns.html
    /// </summary>
    public class Sns
    {

        /// <summary>
        /// TargetArn
        /// The ARN of the Amazon SNS target where the message is sent.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

    }
}
