using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel BurnInDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-burnindestinationsettings.html
    /// </summary>
    public class BurnInDestinationSettings
    {

        /// <summary>
        /// BackgroundOpacity
        /// Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Keeping this
        /// parameter blank is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font
        /// settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BackgroundOpacity")]
        public Union<int, IntrinsicFunction> BackgroundOpacity { get; set; }

        /// <summary>
        /// FontResolution
        /// The font resolution in DPI (dots per inch). The default is 96 dpi. All burn-in and DVB-Sub font
        /// settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FontResolution")]
        public Union<int, IntrinsicFunction> FontResolution { get; set; }

        /// <summary>
        /// OutlineColor
        /// Specifies the font outline color. This option is not valid for source captions that are either
        /// 608/embedded or Teletext. These source settings are already pre-defined by the captions stream. All
        /// burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutlineColor")]
        public Union<string, IntrinsicFunction> OutlineColor { get; set; }

        /// <summary>
        /// FontColor
        /// Specifies the color of the burned-in captions. This option is not valid for source captions that are
        /// STL, 608/embedded, or Teletext. These source settings are already pre-defined by the captions
        /// stream. All burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FontColor")]
        public Union<string, IntrinsicFunction> FontColor { get; set; }

        /// <summary>
        /// ShadowColor
        /// Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must
        /// match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShadowColor")]
        public Union<string, IntrinsicFunction> ShadowColor { get; set; }

        /// <summary>
        /// ShadowOpacity
        /// Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Keeping this parameter blank
        /// is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShadowOpacity")]
        public Union<int, IntrinsicFunction> ShadowOpacity { get; set; }

        /// <summary>
        /// Font
        /// The external font file that is used for captions burn-in. The file extension must be . ttf or . tte.
        /// Although you can select output fonts for many different types of input captions, embedded, STL, and
        /// Teletext sources use a strict grid system. Using external fonts with these captions sources could
        /// cause an unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Font")]
        public InputLocation Font { get; set; }

        /// <summary>
        /// ShadowYOffset
        /// Specifies the vertical offset of the shadow that is relative to the captions in pixels. A value of
        /// -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings
        /// must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShadowYOffset")]
        public Union<int, IntrinsicFunction> ShadowYOffset { get; set; }

        /// <summary>
        /// Alignment
        /// If no explicit xPosition or yPosition is provided, setting alignment to centered places the captions
        /// at the bottom center of the output. Similarly, setting a left alignment aligns captions to the
        /// bottom left of the output. If x and y positions are specified in conjunction with the alignment
        /// parameter, the font is justified (either left or centered) relative to those coordinates. Selecting
        /// &quot;smart&quot; justification left-justifies live subtitles and center-justifies pre-recorded subtitles. All
        /// burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Alignment")]
        public Union<string, IntrinsicFunction> Alignment { get; set; }

        /// <summary>
        /// XPosition
        /// Specifies the horizontal position of the captions relative to the left side of the output in pixels.
        /// A value of 10 would result in the captions starting 10 pixels from the left of the output. If no
        /// explicit xPosition is provided, the horizontal captions position is determined by the alignment
        /// parameter. All burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("XPosition")]
        public Union<int, IntrinsicFunction> XPosition { get; set; }

        /// <summary>
        /// FontSize
        /// When set to auto, fontSize scales depending on the size of the output. Providing a positive integer
        /// specifies the exact font size in points. All burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FontSize")]
        public Union<string, IntrinsicFunction> FontSize { get; set; }

        /// <summary>
        /// YPosition
        /// Specifies the vertical position of the captions relative to the top of the output in pixels. A value
        /// of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit
        /// yPosition is provided, the captions are positioned towards the bottom of the output. All burn-in and
        /// DVB-Sub font settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("YPosition")]
        public Union<int, IntrinsicFunction> YPosition { get; set; }

        /// <summary>
        /// OutlineSize
        /// Specifies font outline size in pixels. This option is not valid for source captions that are either
        /// 608/embedded or Teletext. These source settings are already pre-defined by the captions stream. All
        /// burn-in and DVB-Sub font settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutlineSize")]
        public Union<int, IntrinsicFunction> OutlineSize { get; set; }

        /// <summary>
        /// TeletextGridControl
        /// Controls whether a fixed grid size is used to generate the output subtitles bitmap. This applies
        /// only to Teletext inputs and DVB-Sub/Burn-in outputs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TeletextGridControl")]
        public Union<string, IntrinsicFunction> TeletextGridControl { get; set; }

        /// <summary>
        /// FontOpacity
        /// Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and
        /// DVB-Sub font settings must match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FontOpacity")]
        public Union<int, IntrinsicFunction> FontOpacity { get; set; }

        /// <summary>
        /// ShadowXOffset
        /// Specifies the horizontal offset of the shadow that is relative to the captions in pixels. A value of
        /// -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must
        /// match.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShadowXOffset")]
        public Union<int, IntrinsicFunction> ShadowXOffset { get; set; }

        /// <summary>
        /// BackgroundColor
        /// Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must
        /// match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public Union<string, IntrinsicFunction> BackgroundColor { get; set; }

    }
}
