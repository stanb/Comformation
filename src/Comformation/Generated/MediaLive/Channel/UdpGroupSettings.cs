using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel UdpGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpgroupsettings.html
    /// </summary>
    public class UdpGroupSettings
    {

        /// <summary>
        /// TimedMetadataId3Frame
        /// Indicates the ID3 frame that has the timecode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataId3Frame")]
        public Union<string, IntrinsicFunction> TimedMetadataId3Frame { get; set; }

        /// <summary>
        /// TimedMetadataId3Period
        /// The timed metadata interval in seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataId3Period")]
        public Union<int, IntrinsicFunction> TimedMetadataId3Period { get; set; }

        /// <summary>
        /// InputLossAction
        /// Specifies the behavior of the last resort when the input video is lost, and no more backup inputs
        /// are available. When dropTs is selected, the entire transport stream stops emitting. When dropProgram
        /// is selected, the program can be dropped from the transport stream (and replaced with null packets to
        /// meet the TS bitrate requirement). Or when emitProgram is selected, the transport stream continues to
        /// be produced normally with repeat frames, black frames, or slate frames substituted for the absent
        /// input video.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossAction")]
        public Union<string, IntrinsicFunction> InputLossAction { get; set; }

    }
}
