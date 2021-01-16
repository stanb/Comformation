using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-marginstyle.html
    /// </summary>
    public class MarginStyle
    {

        /// <summary>
        /// Show
        /// </summary>
        [JsonProperty("Show")]
        public Union<bool, IntrinsicFunction> Show { get; set; }

    }
}
