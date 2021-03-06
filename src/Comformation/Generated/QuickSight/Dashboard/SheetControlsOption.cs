using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-sheetcontrolsoption.html
    /// </summary>
    public class SheetControlsOption
    {

        /// <summary>
        /// VisibilityState
        /// </summary>
        [JsonProperty("VisibilityState")]
        public Union<string, IntrinsicFunction> VisibilityState { get; set; }

    }
}
