using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardsourceentity.html
    /// </summary>
    public class DashboardSourceEntity
    {

        /// <summary>
        /// SourceTemplate
        /// </summary>
        [JsonProperty("SourceTemplate")]
        public DashboardSourceTemplate SourceTemplate { get; set; }

    }
}
