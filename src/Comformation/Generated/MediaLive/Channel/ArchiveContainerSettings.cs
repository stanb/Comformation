using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel ArchiveContainerSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archivecontainersettings.html
    /// </summary>
    public class ArchiveContainerSettings
    {

        /// <summary>
        /// RawSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: RawSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RawSettings")]
        public RawSettings RawSettings { get; set; }

        /// <summary>
        /// M2tsSettings
        /// The settings for the M2TS in the archive output.
        /// Required: No
        /// Type: M2tsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("M2tsSettings")]
        public M2tsSettings M2tsSettings { get; set; }

    }
}
