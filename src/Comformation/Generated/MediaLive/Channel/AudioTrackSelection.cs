using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioTrackSelection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrackselection.html
    /// </summary>
    public class AudioTrackSelection
    {

        /// <summary>
        /// Tracks
        /// Selects one or more unique audio tracks from within a source.
        /// Required: No
        /// Type: List of AudioTrack
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tracks")]
        public List<AudioTrack> Tracks { get; set; }

    }
}
