using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme ThemeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html
    /// </summary>
    public class ThemeConfiguration
    {

        /// <summary>
        /// DataColorPalette
        /// Color properties that apply to chart data colors.
        /// Required: No
        /// Type: DataColorPalette
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataColorPalette")]
        public DataColorPalette DataColorPalette { get; set; }

        /// <summary>
        /// UIColorPalette
        /// Color properties that apply to the UI and to charts, excluding the colors that apply to data.
        /// Required: No
        /// Type: UIColorPalette
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UIColorPalette")]
        public UIColorPalette UIColorPalette { get; set; }

        /// <summary>
        /// Sheet
        /// Display options related to sheets.
        /// Required: No
        /// Type: SheetStyle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sheet")]
        public SheetStyle Sheet { get; set; }

        /// <summary>
        /// Typography
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Typography
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Typography")]
        public Typography Typography { get; set; }

    }
}
