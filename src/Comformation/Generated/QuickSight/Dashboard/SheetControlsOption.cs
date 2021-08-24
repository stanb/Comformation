using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard SheetControlsOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrolsoption.html
    /// </summary>
    public class SheetControlsOption
    {

        /// <summary>
        /// VisibilityState
        /// Visibility state.
        /// Required: No
        /// Type: String
        /// Allowed values: COLLAPSED | EXPANDED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VisibilityState")]
        public Union<string, IntrinsicFunction> VisibilityState { get; set; }

    }
}
