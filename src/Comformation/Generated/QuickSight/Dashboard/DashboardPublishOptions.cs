using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html
    /// </summary>
    public class DashboardPublishOptions
    {

        /// <summary>
        /// SheetControlsOption
        /// </summary>
        [JsonProperty("SheetControlsOption")]
        public SheetControlsOption SheetControlsOption { get; set; }

        /// <summary>
        /// ExportToCSVOption
        /// </summary>
        [JsonProperty("ExportToCSVOption")]
        public ExportToCSVOption ExportToCSVOption { get; set; }

        /// <summary>
        /// AdHocFilteringOption
        /// </summary>
        [JsonProperty("AdHocFilteringOption")]
        public AdHocFilteringOption AdHocFilteringOption { get; set; }

    }
}
