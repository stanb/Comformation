using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel KeyProviderSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-keyprovidersettings.html
    /// </summary>
    public class KeyProviderSettings
    {

        /// <summary>
        /// StaticKeySettings
        /// The configuration of static key settings.
        /// Required: No
        /// Type: StaticKeySettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StaticKeySettings")]
        public StaticKeySettings StaticKeySettings { get; set; }

    }
}
