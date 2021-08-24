using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme TileLayoutStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilelayoutstyle.html
    /// </summary>
    public class TileLayoutStyle
    {

        /// <summary>
        /// Gutter
        /// The gutter settings that apply between tiles.
        /// Required: No
        /// Type: GutterStyle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Gutter")]
        public GutterStyle Gutter { get; set; }

        /// <summary>
        /// Margin
        /// The margin settings that apply around the outside edge of sheets.
        /// Required: No
        /// Type: MarginStyle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Margin")]
        public MarginStyle Margin { get; set; }

    }
}
