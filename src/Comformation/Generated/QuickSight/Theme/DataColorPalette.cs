using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html
    /// </summary>
    public class DataColorPalette
    {

        /// <summary>
        /// EmptyFillColor
        /// </summary>
        [JsonProperty("EmptyFillColor")]
        public Union<string, IntrinsicFunction> EmptyFillColor { get; set; }

        /// <summary>
        /// Colors
        /// </summary>
        [JsonProperty("Colors")]
        public List<Union<string, IntrinsicFunction>> Colors { get; set; }

        /// <summary>
        /// MinMaxGradient
        /// </summary>
        [JsonProperty("MinMaxGradient")]
        public List<Union<string, IntrinsicFunction>> MinMaxGradient { get; set; }

    }
}
