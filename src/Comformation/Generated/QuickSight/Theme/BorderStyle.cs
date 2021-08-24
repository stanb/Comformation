using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme BorderStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-borderstyle.html
    /// </summary>
    public class BorderStyle
    {

        /// <summary>
        /// Show
        /// The option to enable display of borders for visuals.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Show")]
        public Union<bool, IntrinsicFunction> Show { get; set; }

    }
}
