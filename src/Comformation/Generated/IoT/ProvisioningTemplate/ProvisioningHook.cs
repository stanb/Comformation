using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.ProvisioningTemplate
{
    /// <summary>
    /// AWS::IoT::ProvisioningTemplate ProvisioningHook
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-provisioningtemplate-provisioninghook.html
    /// </summary>
    public class ProvisioningHook
    {

        /// <summary>
        /// TargetArn
        /// The ARN of the target function.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

        /// <summary>
        /// PayloadVersion
        /// The payload that was sent to the target function. The valid payload is &quot;2020-04-01&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PayloadVersion")]
        public Union<string, IntrinsicFunction> PayloadVersion { get; set; }

    }
}
