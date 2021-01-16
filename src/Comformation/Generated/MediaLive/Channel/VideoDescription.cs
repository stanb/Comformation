using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoDescription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videodescription.html
    /// </summary>
    public class VideoDescription
    {

        /// <summary>
        /// ScalingBehavior
        /// STRETCHTOOUTPUT configures the output position to stretch the video to the specified output
        /// resolution (height and width). This option overrides any position value. DEFAULT might insert black
        /// boxes (pillar boxes or letter boxes) around the video to provide the specified output resolution.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalingBehavior")]
        public Union<string, IntrinsicFunction> ScalingBehavior { get; set; }

        /// <summary>
        /// RespondToAfd
        /// Indicates how to respond to the AFD values in the input stream. RESPOND causes input video to be
        /// clipped, depending on the AFD value, input display aspect ratio, and output display aspect ratio,
        /// and (except for the FRAMECAPTURE codec) includes the values in the output. PASSTHROUGH (does not
        /// apply to FRAMECAPTURE codec) ignores the AFD values and includes the values in the output, so input
        /// video is not clipped. NONE ignores the AFD values and does not include the values through to the
        /// output, so input video is not clipped.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RespondToAfd")]
        public Union<string, IntrinsicFunction> RespondToAfd { get; set; }

        /// <summary>
        /// Height
        /// The output video height, in pixels. This must be an even number. For most codecs, you can keep this
        /// field and width blank in order to use the height and width (resolution) from the source. Note that
        /// we don&#39;t recommend keeping the field blank. For the Frame Capture codec, height and width are
        /// required.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Height")]
        public Union<int, IntrinsicFunction> Height { get; set; }

        /// <summary>
        /// Sharpness
        /// Changes the strength of the anti-alias filter used for scaling. 0 is the softest setting, and 100 is
        /// the sharpest. We recommend a setting of 50 for most content.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sharpness")]
        public Union<int, IntrinsicFunction> Sharpness { get; set; }

        /// <summary>
        /// Width
        /// The output video width, in pixels. It must be an even number. For most codecs, you can keep this
        /// field and height blank in order to use the height and width (resolution) from the source. Note that
        /// we don&#39;t recommend keeping the field blank. For the Frame Capture codec, height and width are
        /// required.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Width")]
        public Union<int, IntrinsicFunction> Width { get; set; }

        /// <summary>
        /// CodecSettings
        /// The video codec settings.
        /// Required: No
        /// Type: VideoCodecSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodecSettings")]
        public VideoCodecSettings CodecSettings { get; set; }

        /// <summary>
        /// Name
        /// The name of this VideoDescription. Outputs use this name to uniquely identify this description.
        /// Description names should be unique within this channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
