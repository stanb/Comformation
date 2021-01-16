using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool DeviceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html
    /// </summary>
    public class DeviceConfiguration
    {

        /// <summary>
        /// DeviceOnlyRememberedOnUserPrompt
        /// If true, a device is only remembered on user prompt.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceOnlyRememberedOnUserPrompt")]
        public Union<bool, IntrinsicFunction> DeviceOnlyRememberedOnUserPrompt { get; set; }

        /// <summary>
        /// ChallengeRequiredOnNewDevice
        /// Indicates whether a challenge is required on a new device. Only applicable to a new device.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChallengeRequiredOnNewDevice")]
        public Union<bool, IntrinsicFunction> ChallengeRequiredOnNewDevice { get; set; }

    }
}
