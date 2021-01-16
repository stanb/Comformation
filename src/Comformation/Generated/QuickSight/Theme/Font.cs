using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-font.html
    /// </summary>
    public class Font
    {

        /// <summary>
        /// FontFamily
        /// </summary>
        [JsonProperty("FontFamily")]
        public Union<string, IntrinsicFunction> FontFamily { get; set; }

    }
}
