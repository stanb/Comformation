using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel EbuTtDDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ebuttddestinationsettings.html
    /// </summary>
    public class EbuTtDDestinationSettings
    {

        /// <summary>
        /// FontFamily
        /// Specifies the font family to include in the font data attached to the EBU-TT captions. Valid only if
        /// styleControl is set to include. If you leave this field empty, the font family is set to
        /// &quot;monospaced&quot;. (If styleControl is set to exclude, the font family is always set to &quot;monospaced&quot;. )
        /// You specify only the font family. All other style information (color, bold, position and so on) is
        /// copied from the input captions. The size is always set to 100% to allow the downstream player to
        /// choose the size. - Enter a list of font families, as a comma-separated list of font names, in order
        /// of preference. The name can be a font family (such as “Arial”), or a generic font family (such as
        /// “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the
        /// family to “monospace”.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FontFamily")]
        public Union<string, IntrinsicFunction> FontFamily { get; set; }

        /// <summary>
        /// FillLineGap
        /// Specifies how to handle the gap between the lines (in multi-line captions). - enabled: Fill with the
        /// captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FillLineGap")]
        public Union<string, IntrinsicFunction> FillLineGap { get; set; }

        /// <summary>
        /// StyleControl
        /// Specifies the style information (font color, font position, and so on) to include in the font data
        /// that is attached to the EBU-TT captions. - include: Take the style information (font color, font
        /// position, and so on) from the source captions and include that information in the font data attached
        /// to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. -
        /// exclude: In the font data attached to the EBU-TT captions, set the font family to &quot;monospaced&quot;. Do
        /// not include any other style information.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StyleControl")]
        public Union<string, IntrinsicFunction> StyleControl { get; set; }

    }
}
