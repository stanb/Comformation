using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme DataColorPalette
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html
    /// </summary>
    public class DataColorPalette
    {

        /// <summary>
        /// EmptyFillColor
        /// The hexadecimal code of a color that applies to charts where a lack of data is highlighted.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmptyFillColor")]
        public Union<string, IntrinsicFunction> EmptyFillColor { get; set; }

        /// <summary>
        /// Colors
        /// The hexadecimal codes for the colors.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Colors")]
        public List<Union<string, IntrinsicFunction>> Colors { get; set; }

        /// <summary>
        /// MinMaxGradient
        /// The minimum and maximum hexadecimal codes that describe a color gradient.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinMaxGradient")]
        public List<Union<string, IntrinsicFunction>> MinMaxGradient { get; set; }

    }
}
