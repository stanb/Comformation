using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard DashboardSourceEntity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourceentity.html
    /// </summary>
    public class DashboardSourceEntity
    {

        /// <summary>
        /// SourceTemplate
        /// Source template.
        /// Required: No
        /// Type: DashboardSourceTemplate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceTemplate")]
        public DashboardSourceTemplate SourceTemplate { get; set; }

    }
}
