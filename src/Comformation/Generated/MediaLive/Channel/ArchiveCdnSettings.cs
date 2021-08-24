using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel ArchiveCdnSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecdnsettings.html
    /// </summary>
    public class ArchiveCdnSettings
    {

        /// <summary>
        /// ArchiveS3Settings
        /// Sets up Amazon S3 as the destination for this Archive output.
        /// Required: No
        /// Type: ArchiveS3Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArchiveS3Settings")]
        public ArchiveS3Settings ArchiveS3Settings { get; set; }

    }
}
