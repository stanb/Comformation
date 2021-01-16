using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AacSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-aacsettings.html
    /// </summary>
    public class AacSettings
    {

        /// <summary>
        /// CodingMode
        /// Mono, stereo, or 5. 1 channel layout. Valid values depend on the rate control mode and profile. The
        /// adReceiverMix setting receives a stereo description plus control track, and emits a mono AAC encode
        /// of the description track, with control data emitted in the PES header as per ETSI TS 101 154 Annex
        /// E.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodingMode")]
        public Union<string, IntrinsicFunction> CodingMode { get; set; }

        /// <summary>
        /// RateControlMode
        /// The rate control mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RateControlMode")]
        public Union<string, IntrinsicFunction> RateControlMode { get; set; }

        /// <summary>
        /// SampleRate
        /// The sample rate in Hz. Valid values depend on the rate control mode and profile.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SampleRate")]
        public Union<double, IntrinsicFunction> SampleRate { get; set; }

        /// <summary>
        /// InputType
        /// Set to broadcasterMixedAd when the input contains pre-mixed main audio + AD (narration) as a stereo
        /// pair. The Audio Type field (audioType) will be set to 3, which signals to downstream systems that
        /// this stream contains broadcaster mixed AD. Note that the input received by the encoder must contain
        /// pre-mixed audio; MediaLive does not perform the mixing. The values in audioTypeControl and audioType
        /// (in AudioDescription) are ignored when set to broadcasterMixedAd. Leave this set to normal when the
        /// input does not contain pre-mixed audio + AD.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputType")]
        public Union<string, IntrinsicFunction> InputType { get; set; }

        /// <summary>
        /// VbrQuality
        /// The VBR quality level. This is used only if rateControlMode is VBR.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VbrQuality")]
        public Union<string, IntrinsicFunction> VbrQuality { get; set; }

        /// <summary>
        /// RawFormat
        /// Sets the LATM/LOAS AAC output for raw containers.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RawFormat")]
        public Union<string, IntrinsicFunction> RawFormat { get; set; }

        /// <summary>
        /// Spec
        /// Uses MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Spec")]
        public Union<string, IntrinsicFunction> Spec { get; set; }

        /// <summary>
        /// Bitrate
        /// The average bitrate in bits/second. Valid values depend on the rate control mode and profile.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<double, IntrinsicFunction> Bitrate { get; set; }

        /// <summary>
        /// Profile
        /// The AAC profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Profile")]
        public Union<string, IntrinsicFunction> Profile { get; set; }

    }
}
