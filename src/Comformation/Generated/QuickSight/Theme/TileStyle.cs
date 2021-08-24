using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme TileStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html
    /// </summary>
    public class TileStyle
    {

        /// <summary>
        /// Border
        /// The border around a tile.
        /// Required: No
        /// Type: BorderStyle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Border")]
        public BorderStyle Border { get; set; }

    }
}
