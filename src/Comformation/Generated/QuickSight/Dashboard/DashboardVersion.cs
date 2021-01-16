using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-dashboardversion.html
    /// </summary>
    public class DashboardVersion
    {

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty("Errors")]
        public List<DashboardError> Errors { get; set; }

        /// <summary>
        /// CreatedTime
        /// </summary>
        [JsonProperty("CreatedTime")]
        public Union<string, IntrinsicFunction> CreatedTime { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DataSetArns
        /// </summary>
        [JsonProperty("DataSetArns")]
        public List<Union<string, IntrinsicFunction>> DataSetArns { get; set; }

        /// <summary>
        /// ThemeArn
        /// </summary>
        [JsonProperty("ThemeArn")]
        public Union<string, IntrinsicFunction> ThemeArn { get; set; }

        /// <summary>
        /// Arn
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// SourceEntityArn
        /// </summary>
        [JsonProperty("SourceEntityArn")]
        public Union<string, IntrinsicFunction> SourceEntityArn { get; set; }

        /// <summary>
        /// VersionNumber
        /// </summary>
        [JsonProperty("VersionNumber")]
        public Union<double, IntrinsicFunction> VersionNumber { get; set; }

        /// <summary>
        /// Sheets
        /// </summary>
        [JsonProperty("Sheets")]
        public List<Sheet> Sheets { get; set; }

    }
}
