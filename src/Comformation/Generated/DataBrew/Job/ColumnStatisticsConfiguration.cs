using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job ColumnStatisticsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnstatisticsconfiguration.html
    /// </summary>
    public class ColumnStatisticsConfiguration
    {

        /// <summary>
        /// Selectors
        /// List of column selectors. Selectors can be used to select columns from the dataset. When selectors
        /// are undefined, configuration will be applied to all supported columns.
        /// Required: No
        /// Type: List of ColumnSelector
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Selectors")]
        public List<ColumnSelector> Selectors { get; set; }

        /// <summary>
        /// Statistics
        /// Configuration for evaluations. Statistics can be used to select evaluations and override parameters
        /// of evaluations.
        /// Required: Yes
        /// Type: StatisticsConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statistics")]
        public StatisticsConfiguration Statistics { get; set; }

    }
}
