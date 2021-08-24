using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel EncoderSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-encodersettings.html
    /// </summary>
    public class EncoderSettings
    {

        /// <summary>
        /// AudioDescriptions
        /// The encoding information for output audio.
        /// Required: No
        /// Type: List of AudioDescription
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioDescriptions")]
        public List<AudioDescription> AudioDescriptions { get; set; }

        /// <summary>
        /// VideoDescriptions
        /// The encoding information for output videos.
        /// Required: No
        /// Type: List of VideoDescription
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoDescriptions")]
        public List<VideoDescription> VideoDescriptions { get; set; }

        /// <summary>
        /// FeatureActivations
        /// Settings to enable specific features.
        /// Required: No
        /// Type: FeatureActivations
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FeatureActivations")]
        public FeatureActivations FeatureActivations { get; set; }

        /// <summary>
        /// GlobalConfiguration
        /// The configuration settings that apply to the entire channel.
        /// Required: No
        /// Type: GlobalConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlobalConfiguration")]
        public GlobalConfiguration GlobalConfiguration { get; set; }

        /// <summary>
        /// CaptionDescriptions
        /// The encoding information for output captions.
        /// Required: No
        /// Type: List of CaptionDescription
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionDescriptions")]
        public List<CaptionDescription> CaptionDescriptions { get; set; }

        /// <summary>
        /// AvailConfiguration
        /// The configuration settings for the ad avail handling.
        /// Required: No
        /// Type: AvailConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailConfiguration")]
        public AvailConfiguration AvailConfiguration { get; set; }

        /// <summary>
        /// MotionGraphicsConfiguration
        /// Settings to enable and configure the motion graphics overlay feature in the channel.
        /// Required: No
        /// Type: MotionGraphicsConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MotionGraphicsConfiguration")]
        public MotionGraphicsConfiguration MotionGraphicsConfiguration { get; set; }

        /// <summary>
        /// OutputGroups
        /// The settings for the output groups in the channel.
        /// Required: No
        /// Type: List of OutputGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputGroups")]
        public List<OutputGroup> OutputGroups { get; set; }

        /// <summary>
        /// AvailBlanking
        /// The settings for ad avail blanking.
        /// Required: No
        /// Type: AvailBlanking
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailBlanking")]
        public AvailBlanking AvailBlanking { get; set; }

        /// <summary>
        /// NielsenConfiguration
        /// The settings to configure Nielsen watermarks.
        /// Required: No
        /// Type: NielsenConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NielsenConfiguration")]
        public NielsenConfiguration NielsenConfiguration { get; set; }

        /// <summary>
        /// BlackoutSlate
        /// The settings for the blackout slate.
        /// Required: No
        /// Type: BlackoutSlate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlackoutSlate")]
        public BlackoutSlate BlackoutSlate { get; set; }

        /// <summary>
        /// TimecodeConfig
        /// Contains settings used to acquire and adjust timecode information from the inputs.
        /// Required: No
        /// Type: TimecodeConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimecodeConfig")]
        public TimecodeConfig TimecodeConfig { get; set; }

    }
}
