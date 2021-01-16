using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilelayoutstyle.html
    /// </summary>
    public class TileLayoutStyle
    {

        /// <summary>
        /// Gutter
        /// </summary>
        [JsonProperty("Gutter")]
        public GutterStyle Gutter { get; set; }

        /// <summary>
        /// Margin
        /// </summary>
        [JsonProperty("Margin")]
        public MarginStyle Margin { get; set; }

    }
}
