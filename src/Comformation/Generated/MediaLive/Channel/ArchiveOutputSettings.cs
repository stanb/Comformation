using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel ArchiveOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archiveoutputsettings.html
    /// </summary>
    public class ArchiveOutputSettings
    {

        /// <summary>
        /// Extension
        /// The output file extension. If excluded, this is auto-selected from the container type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Extension")]
        public Union<string, IntrinsicFunction> Extension { get; set; }

        /// <summary>
        /// NameModifier
        /// A string that is concatenated to the end of the destination file name. The string is required for
        /// multiple outputs of the same type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NameModifier")]
        public Union<string, IntrinsicFunction> NameModifier { get; set; }

        /// <summary>
        /// ContainerSettings
        /// The settings that are specific to the container type of the file.
        /// Required: No
        /// Type: ArchiveContainerSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerSettings")]
        public ArchiveContainerSettings ContainerSettings { get; set; }

    }
}
