using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme MarginStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-marginstyle.html
    /// </summary>
    public class MarginStyle
    {

        /// <summary>
        /// Show
        /// This Boolean value controls whether to display sheet margins.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Show")]
        public Union<bool, IntrinsicFunction> Show { get; set; }

    }
}
