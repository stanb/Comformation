using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AvailSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availsettings.html
    /// </summary>
    public class AvailSettings
    {

        /// <summary>
        /// Scte35SpliceInsert
        /// The setup for SCTE-35 splice insert handling.
        /// Required: No
        /// Type: Scte35SpliceInsert
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte35SpliceInsert")]
        public Scte35SpliceInsert Scte35SpliceInsert { get; set; }

        /// <summary>
        /// Scte35TimeSignalApos
        /// The setup for SCTE-35 time signal APOS handling.
        /// Required: No
        /// Type: Scte35TimeSignalApos
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte35TimeSignalApos")]
        public Scte35TimeSignalApos Scte35TimeSignalApos { get; set; }

    }
}
