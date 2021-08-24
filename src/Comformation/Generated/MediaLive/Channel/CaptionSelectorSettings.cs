using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CaptionSelectorSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html
    /// </summary>
    public class CaptionSelectorSettings
    {

        /// <summary>
        /// DvbSubSourceSettings
        /// Information about the DVB Sub captions to extract from the input.
        /// Required: No
        /// Type: DvbSubSourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbSubSourceSettings")]
        public DvbSubSourceSettings DvbSubSourceSettings { get; set; }

        /// <summary>
        /// Scte27SourceSettings
        /// Information about the SCTE-27 captions to extract from the input.
        /// Required: No
        /// Type: Scte27SourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte27SourceSettings")]
        public Scte27SourceSettings Scte27SourceSettings { get; set; }

        /// <summary>
        /// AribSourceSettings
        /// Information about the ARIB captions to extract from the input.
        /// Required: No
        /// Type: AribSourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AribSourceSettings")]
        public AribSourceSettings AribSourceSettings { get; set; }

        /// <summary>
        /// EmbeddedSourceSettings
        /// Information about the embedded captions to extract from the input.
        /// Required: No
        /// Type: EmbeddedSourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmbeddedSourceSettings")]
        public EmbeddedSourceSettings EmbeddedSourceSettings { get; set; }

        /// <summary>
        /// Scte20SourceSettings
        /// Information about the SCTE-20 captions to extract from the input.
        /// Required: No
        /// Type: Scte20SourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte20SourceSettings")]
        public Scte20SourceSettings Scte20SourceSettings { get; set; }

        /// <summary>
        /// TeletextSourceSettings
        /// Information about the Teletext captions to extract from the input.
        /// Required: No
        /// Type: TeletextSourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TeletextSourceSettings")]
        public TeletextSourceSettings TeletextSourceSettings { get; set; }

        /// <summary>
        /// AncillarySourceSettings
        /// Information about the ancillary captions to extract from the input.
        /// Required: No
        /// Type: AncillarySourceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AncillarySourceSettings")]
        public AncillarySourceSettings AncillarySourceSettings { get; set; }

    }
}
