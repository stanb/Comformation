using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard DashboardPublishOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardpublishoptions.html
    /// </summary>
    public class DashboardPublishOptions
    {

        /// <summary>
        /// SheetControlsOption
        /// Sheet controls option.
        /// Required: No
        /// Type: SheetControlsOption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SheetControlsOption")]
        public SheetControlsOption SheetControlsOption { get; set; }

        /// <summary>
        /// ExportToCSVOption
        /// Export to . csv option.
        /// Required: No
        /// Type: ExportToCSVOption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExportToCSVOption")]
        public ExportToCSVOption ExportToCSVOption { get; set; }

        /// <summary>
        /// AdHocFilteringOption
        /// Ad hoc (one-time) filtering option.
        /// Required: No
        /// Type: AdHocFilteringOption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdHocFilteringOption")]
        public AdHocFilteringOption AdHocFilteringOption { get; set; }

    }
}
