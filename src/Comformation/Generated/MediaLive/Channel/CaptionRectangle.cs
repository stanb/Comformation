using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CaptionRectangle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionrectangle.html
    /// </summary>
    public class CaptionRectangle
    {

        /// <summary>
        /// TopOffset
        /// See the description in leftOffset.
        /// For topOffset, specify the position of the top edge of the rectangle, as a percentage of the
        /// underlying frame height, and relative to the top edge of the frame. For example, \&quot;10\&quot; means the
        /// measurement is 10% of the underlying frame height. The rectangle top edge starts at that position
        /// from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopOffset")]
        public Union<double, IntrinsicFunction> TopOffset { get; set; }

        /// <summary>
        /// Height
        /// See the description in leftOffset.
        /// For height, specify the entire height of the rectangle as a percentage of the underlying frame
        /// height. For example, \&quot;80\&quot; means the rectangle height is 80% of the underlying frame height. The
        /// topOffset and rectangleHeight must add up to 100% or less. This field corresponds to tts:extent - Y
        /// in the TTML standard.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Height")]
        public Union<double, IntrinsicFunction> Height { get; set; }

        /// <summary>
        /// Width
        /// See the description in leftOffset.
        /// For width, specify the entire width of the rectangle as a percentage of the underlying frame width.
        /// For example, \&quot;80\&quot; means the rectangle width is 80% of the underlying frame width. The leftOffset
        /// and rectangleWidth must add up to 100% or less. This field corresponds to tts:extent - X in the TTML
        /// standard.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Width")]
        public Union<double, IntrinsicFunction> Width { get; set; }

        /// <summary>
        /// LeftOffset
        /// Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make
        /// sure to leave the default if you don&#39;t have either of these formats in the output. ) You can define
        /// a display rectangle for the captions that is smaller than the underlying video frame. You define the
        /// rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the
        /// rectangle, all within the underlying video frame. The units for the measurements are percentages. If
        /// you specify a value for one of these fields, you must specify a value for all of them.
        /// For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the
        /// underlying frame width, and relative to the left edge of the frame. For example, \&quot;10\&quot; means the
        /// measurement is 10% of the underlying frame width. The rectangle left edge starts at that position
        /// from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LeftOffset")]
        public Union<double, IntrinsicFunction> LeftOffset { get; set; }

    }
}
