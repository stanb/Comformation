using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job ProfileConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html
    /// </summary>
    public class ProfileConfiguration
    {

        /// <summary>
        /// DatasetStatisticsConfiguration
        /// Configuration for inter-column evaluations. Configuration can be used to select evaluations and
        /// override parameters of evaluations. When configuration is undefined, the profile job will run all
        /// supported inter-column evaluations.
        /// Required: No
        /// Type: StatisticsConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetStatisticsConfiguration")]
        public StatisticsConfiguration DatasetStatisticsConfiguration { get; set; }

        /// <summary>
        /// ProfileColumns
        /// List of column selectors. ProfileColumns can be used to select columns from the dataset. When
        /// ProfileColumns is undefined, the profile job will profile all supported columns.
        /// Required: No
        /// Type: List of ColumnSelector
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProfileColumns")]
        public List<ColumnSelector> ProfileColumns { get; set; }

        /// <summary>
        /// ColumnStatisticsConfigurations
        /// List of configurations for column evaluations. ColumnStatisticsConfigurations are used to select
        /// evaluations and override parameters of evaluations for particular columns. When
        /// ColumnStatisticsConfigurations is undefined, the profile job will profile all supported columns and
        /// run all supported evaluations.
        /// Required: No
        /// Type: List of ColumnStatisticsConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnStatisticsConfigurations")]
        public List<ColumnStatisticsConfiguration> ColumnStatisticsConfigurations { get; set; }

    }
}
