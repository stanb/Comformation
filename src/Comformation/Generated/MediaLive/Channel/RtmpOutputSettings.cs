using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel RtmpOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpoutputsettings.html
    /// </summary>
    public class RtmpOutputSettings
    {

        /// <summary>
        /// Destination
        /// The RTMP endpoint excluding the stream name (for example, rtmp://host/appname).
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// CertificateMode
        /// If set to verifyAuthenticity, verifies the TLS certificate chain to a trusted certificate authority
        /// (CA). This causes RTMPS outputs with self-signed certificates to fail.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateMode")]
        public Union<string, IntrinsicFunction> CertificateMode { get; set; }

        /// <summary>
        /// NumRetries
        /// The number of retry attempts.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRetries")]
        public Union<int, IntrinsicFunction> NumRetries { get; set; }

        /// <summary>
        /// ConnectionRetryInterval
        /// The number of seconds to wait before retrying a connection to the Flash Media server if the
        /// connection is lost.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionRetryInterval")]
        public Union<int, IntrinsicFunction> ConnectionRetryInterval { get; set; }

    }
}
