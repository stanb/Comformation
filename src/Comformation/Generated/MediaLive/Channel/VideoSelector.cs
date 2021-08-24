using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoSelector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html
    /// </summary>
    public class VideoSelector
    {

        /// <summary>
        /// ColorSpaceSettings
        /// Settings to configure color space settings in the incoming video.
        /// Required: No
        /// Type: VideoSelectorColorSpaceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpaceSettings")]
        public VideoSelectorColorSpaceSettings ColorSpaceSettings { get; set; }

        /// <summary>
        /// SelectorSettings
        /// Information about the video to select from the content.
        /// Required: No
        /// Type: VideoSelectorSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectorSettings")]
        public VideoSelectorSettings SelectorSettings { get; set; }

        /// <summary>
        /// ColorSpace
        /// Specifies the color space of an input. This setting works in tandem with colorSpaceConversion to
        /// determine if MediaLive will perform any conversion.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpace")]
        public Union<string, IntrinsicFunction> ColorSpace { get; set; }

        /// <summary>
        /// ColorSpaceUsage
        /// Applies only if colorSpace is a value other than Follow. This field controls how the value in the
        /// colorSpace field is used. Fallback means that when the input does include color space data, that
        /// data is used, but when the input has no color space data, the value in colorSpace is used. Choose
        /// fallback if your input is sometimes missing color space data, but when it does have color space
        /// data, that data is correct. Force means to always use the value in colorSpace. Choose force if your
        /// input usually has no color space data or might have unreliable color space data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpaceUsage")]
        public Union<string, IntrinsicFunction> ColorSpaceUsage { get; set; }

    }
}
