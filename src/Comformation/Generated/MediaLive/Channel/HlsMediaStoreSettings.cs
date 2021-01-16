using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel HlsMediaStoreSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsmediastoresettings.html
    /// </summary>
    public class HlsMediaStoreSettings
    {

        /// <summary>
        /// FilecacheDuration
        /// The size, in seconds, of the file cache for streaming outputs.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilecacheDuration")]
        public Union<int, IntrinsicFunction> FilecacheDuration { get; set; }

        /// <summary>
        /// NumRetries
        /// The number of retry attempts that are made before the channel is put into an error state.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRetries")]
        public Union<int, IntrinsicFunction> NumRetries { get; set; }

        /// <summary>
        /// MediaStoreStorageClass
        /// When set to temporal, output files are stored in non-persistent memory for faster reading and
        /// writing.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediaStoreStorageClass")]
        public Union<string, IntrinsicFunction> MediaStoreStorageClass { get; set; }

        /// <summary>
        /// RestartDelay
        /// If a streaming output fails, the number of seconds to wait until a restart is initiated. A value of
        /// 0 means never restart.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestartDelay")]
        public Union<int, IntrinsicFunction> RestartDelay { get; set; }

        /// <summary>
        /// ConnectionRetryInterval
        /// The number of seconds to wait before retrying a connection to the CDN if the connection is lost.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionRetryInterval")]
        public Union<int, IntrinsicFunction> ConnectionRetryInterval { get; set; }

    }
}
