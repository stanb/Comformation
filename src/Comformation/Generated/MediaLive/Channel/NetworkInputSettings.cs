using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel NetworkInputSettings
    /// Information about how to connect to the upstream system.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html
    /// </summary>
    public class NetworkInputSettings
    {

        /// <summary>
        /// ServerValidation
        /// Checks HTTPS server certificates. When set to checkCryptographyOnly, cryptography in the certificate
        /// is checked, but not the server&#39;s name. Certain subdomains (notably S3 buckets that use dots in the
        /// bucket name) don&#39;t strictly match the corresponding certificate&#39;s wildcard pattern and would
        /// otherwise cause the channel to error. This setting is ignored for protocols that do not use HTTPS.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerValidation")]
        public Union<string, IntrinsicFunction> ServerValidation { get; set; }

        /// <summary>
        /// HlsInputSettings
        /// Information about how to connect to the upstream system.
        /// Required: No
        /// Type: HlsInputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsInputSettings")]
        public HlsInputSettings HlsInputSettings { get; set; }

    }
}
