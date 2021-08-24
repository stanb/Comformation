using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel ArchiveGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivegroupsettings.html
    /// </summary>
    public class ArchiveGroupSettings
    {

        /// <summary>
        /// Destination
        /// A directory and base file name where archive files should be written.
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// ArchiveCdnSettings
        /// Settings to configure the destination of an Archive output.
        /// Required: No
        /// Type: ArchiveCdnSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArchiveCdnSettings")]
        public ArchiveCdnSettings ArchiveCdnSettings { get; set; }

        /// <summary>
        /// RolloverInterval
        /// The number of seconds to write to an archive file before closing and starting a new one.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RolloverInterval")]
        public Union<int, IntrinsicFunction> RolloverInterval { get; set; }

    }
}
