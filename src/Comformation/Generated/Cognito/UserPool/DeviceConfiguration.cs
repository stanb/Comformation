using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// Amazon Cognito UserPool DeviceConfiguration
    /// DeviceConfiguration is a property of the AWS::Cognito::UserPool resource that defines the device configuration
    /// of an Amazon Cognito User Pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html
    /// </summary>
    public class DeviceConfiguration
    {

        /// <summary>
        /// DeviceOnlyRememberedOnUserPrompt
        /// If true, a device is only remembered on user prompt.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("DeviceOnlyRememberedOnUserPrompt")]
        public Union<bool, IntrinsicFunction> DeviceOnlyRememberedOnUserPrompt { get; set; }

        /// <summary>
        /// ChallengeRequiredOnNewDevice
        /// Indicates whether a challenge is required on a new device. Only applicable to a new device.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("ChallengeRequiredOnNewDevice")]
        public Union<bool, IntrinsicFunction> ChallengeRequiredOnNewDevice { get; set; }

    }
}
