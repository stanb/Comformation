using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html
    /// </summary>
    public class Typography
    {

        /// <summary>
        /// FontFamilies
        /// </summary>
        [JsonProperty("FontFamilies")]
        public List<Font> FontFamilies { get; set; }

    }
}
