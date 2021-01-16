using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel StaticKeySettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-statickeysettings.html
    /// </summary>
    public class StaticKeySettings
    {

        /// <summary>
        /// KeyProviderServer
        /// The URL of the license server that is used for protecting content.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyProviderServer")]
        public InputLocation KeyProviderServer { get; set; }

        /// <summary>
        /// StaticKeyValue
        /// The static key value as a 32 character hexadecimal string.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StaticKeyValue")]
        public Union<string, IntrinsicFunction> StaticKeyValue { get; set; }

    }
}
