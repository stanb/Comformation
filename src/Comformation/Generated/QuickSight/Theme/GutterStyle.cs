using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme GutterStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-gutterstyle.html
    /// </summary>
    public class GutterStyle
    {

        /// <summary>
        /// Show
        /// This Boolean value controls whether to display a gutter space between sheet tiles.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Show")]
        public Union<bool, IntrinsicFunction> Show { get; set; }

    }
}
