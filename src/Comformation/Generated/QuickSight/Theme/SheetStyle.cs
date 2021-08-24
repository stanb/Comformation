using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme SheetStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html
    /// </summary>
    public class SheetStyle
    {

        /// <summary>
        /// TileLayout
        /// The layout options for tiles.
        /// Required: No
        /// Type: TileLayoutStyle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TileLayout")]
        public TileLayoutStyle TileLayout { get; set; }

        /// <summary>
        /// Tile
        /// The display options for tiles.
        /// Required: No
        /// Type: TileStyle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tile")]
        public TileStyle Tile { get; set; }

    }
}
