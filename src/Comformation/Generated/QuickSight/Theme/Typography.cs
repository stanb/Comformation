using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme Typography
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html
    /// </summary>
    public class Typography
    {

        /// <summary>
        /// FontFamilies
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of Font
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FontFamilies")]
        public List<Font> FontFamilies { get; set; }

    }
}
