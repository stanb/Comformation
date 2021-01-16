using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html
    /// </summary>
    public class ThemeConfiguration
    {

        /// <summary>
        /// DataColorPalette
        /// </summary>
        [JsonProperty("DataColorPalette")]
        public DataColorPalette DataColorPalette { get; set; }

        /// <summary>
        /// UIColorPalette
        /// </summary>
        [JsonProperty("UIColorPalette")]
        public UIColorPalette UIColorPalette { get; set; }

        /// <summary>
        /// Sheet
        /// </summary>
        [JsonProperty("Sheet")]
        public SheetStyle Sheet { get; set; }

        /// <summary>
        /// Typography
        /// </summary>
        [JsonProperty("Typography")]
        public Typography Typography { get; set; }

    }
}
