using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile AlertTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-alerttarget.html
    /// </summary>
    public class AlertTarget
    {

        /// <summary>
        /// AlertTargetArn
        /// The Amazon Resource Name (ARN) of the notification target to which alerts are sent.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlertTargetArn")]
        public Union<string, IntrinsicFunction> AlertTargetArn { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants permission to send alerts to the notification target.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
