using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.DeviceDefinitionVersion
{
    /// <summary>
    /// AWS IoT Greengrass DeviceDefinitionVersion Device
    /// A device is an AWS IoT device (thing) that&#39;s added to a Greengrass group. 	 Greengrass devices can communicate
    /// with the Greengrass core in the same group. 	 For more information, see What Is AWS IoT Greengrass? in the AWS
    /// IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinitionversion-device.html
    /// </summary>
    public class Device
    {

        /// <summary>
        /// SyncShadow
        /// Indicates whether the devices&#39;s local shadow is synced with the cloud automatically.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SyncShadow")]
        public Union<bool, IntrinsicFunction> SyncShadow { get; set; }

        /// <summary>
        /// ThingArn
        /// The ARN of the device, which is an AWS IoT device (thing).
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ThingArn")]
        public Union<string, IntrinsicFunction> ThingArn { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the device. This value must be unique within the device definition
        /// version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// CertificateArn
        /// The ARN of the device certificate for the device. This X. 509 certificate is used to authenticate
        /// the device with AWS IoT and AWS IoT Greengrass services.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}