using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html
    /// </summary>
    public class TileStyle
    {

        /// <summary>
        /// Border
        /// </summary>
        [JsonProperty("Border")]
        public BorderStyle Border { get; set; }

    }
}
