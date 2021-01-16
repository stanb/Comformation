using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Device
{
    /// <summary>
    /// AWS::SageMaker::Device Device
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-device-device.html
    /// </summary>
    public class Device
    {

        /// <summary>
        /// Description
        /// Description of the device.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 40
        /// Pattern: [\S\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DeviceName
        /// The name of the device.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// IotThingName
        /// AWS Internet of Things (IoT) object name.
        /// Required: No
        /// Type: String
        /// Maximum: 128
        /// Pattern: [a-zA-Z0-9:_-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotThingName")]
        public Union<string, IntrinsicFunction> IotThingName { get; set; }

    }
}
