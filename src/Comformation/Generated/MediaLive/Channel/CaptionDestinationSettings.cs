using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CaptionDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondestinationsettings.html
    /// </summary>
    public class CaptionDestinationSettings
    {

        /// <summary>
        /// AribDestinationSettings
        /// The configuration of one ARIB captions encode in the output.
        /// Required: No
        /// Type: AribDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AribDestinationSettings")]
        public AribDestinationSettings AribDestinationSettings { get; set; }

        /// <summary>
        /// EbuTtDDestinationSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: EbuTtDDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbuTtDDestinationSettings")]
        public EbuTtDDestinationSettings EbuTtDDestinationSettings { get; set; }

        /// <summary>
        /// SmpteTtDestinationSettings
        /// The configuration of one SMPTE-TT captions encode in the output.
        /// Required: No
        /// Type: SmpteTtDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SmpteTtDestinationSettings")]
        public SmpteTtDestinationSettings SmpteTtDestinationSettings { get; set; }

        /// <summary>
        /// EmbeddedPlusScte20DestinationSettings
        /// The configuration of one embedded plus SCTE-20 captions encode in the output.
        /// Required: No
        /// Type: EmbeddedPlusScte20DestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmbeddedPlusScte20DestinationSettings")]
        public EmbeddedPlusScte20DestinationSettings EmbeddedPlusScte20DestinationSettings { get; set; }

        /// <summary>
        /// TtmlDestinationSettings
        /// The configuration of one TTML captions encode in the output.
        /// Required: No
        /// Type: TtmlDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TtmlDestinationSettings")]
        public TtmlDestinationSettings TtmlDestinationSettings { get; set; }

        /// <summary>
        /// Scte20PlusEmbeddedDestinationSettings
        /// The configuration of one SCTE20 plus embedded captions encode in the output.
        /// Required: No
        /// Type: Scte20PlusEmbeddedDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte20PlusEmbeddedDestinationSettings")]
        public Scte20PlusEmbeddedDestinationSettings Scte20PlusEmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// DvbSubDestinationSettings
        /// The configuration of one DVB Sub captions encode in the output.
        /// Required: No
        /// Type: DvbSubDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbSubDestinationSettings")]
        public DvbSubDestinationSettings DvbSubDestinationSettings { get; set; }

        /// <summary>
        /// TeletextDestinationSettings
        /// The configuration of one Teletext captions encode in the output.
        /// Required: No
        /// Type: TeletextDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TeletextDestinationSettings")]
        public TeletextDestinationSettings TeletextDestinationSettings { get; set; }

        /// <summary>
        /// BurnInDestinationSettings
        /// The configuration of one burn-in captions encode in the output.
        /// Required: No
        /// Type: BurnInDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BurnInDestinationSettings")]
        public BurnInDestinationSettings BurnInDestinationSettings { get; set; }

        /// <summary>
        /// WebvttDestinationSettings
        /// The configuration of one WebVTT captions encode in the output.
        /// Required: No
        /// Type: WebvttDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WebvttDestinationSettings")]
        public WebvttDestinationSettings WebvttDestinationSettings { get; set; }

        /// <summary>
        /// EmbeddedDestinationSettings
        /// The configuration of one embedded captions encode in the output.
        /// Required: No
        /// Type: EmbeddedDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmbeddedDestinationSettings")]
        public EmbeddedDestinationSettings EmbeddedDestinationSettings { get; set; }

        /// <summary>
        /// RtmpCaptionInfoDestinationSettings
        /// The configuration of one RTMPCaptionInfo captions encode in the output.
        /// Required: No
        /// Type: RtmpCaptionInfoDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RtmpCaptionInfoDestinationSettings")]
        public RtmpCaptionInfoDestinationSettings RtmpCaptionInfoDestinationSettings { get; set; }

        /// <summary>
        /// Scte27DestinationSettings
        /// The configuration of one SCTE-27 captions encode in the output.
        /// Required: No
        /// Type: Scte27DestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte27DestinationSettings")]
        public Scte27DestinationSettings Scte27DestinationSettings { get; set; }

    }
}
