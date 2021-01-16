using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html
    /// </summary>
    public class SheetStyle
    {

        /// <summary>
        /// TileLayout
        /// </summary>
        [JsonProperty("TileLayout")]
        public TileLayoutStyle TileLayout { get; set; }

        /// <summary>
        /// Tile
        /// </summary>
        [JsonProperty("Tile")]
        public TileStyle Tile { get; set; }

    }
}
