using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job StatisticsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticsconfiguration.html
    /// </summary>
    public class StatisticsConfiguration
    {

        /// <summary>
        /// IncludedStatistics
        /// List of included evaluations. When the list is undefined, all supported evaluations will be
        /// included.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludedStatistics")]
        public List<Union<string, IntrinsicFunction>> IncludedStatistics { get; set; }

        /// <summary>
        /// Overrides
        /// List of overrides for evaluations.
        /// Required: No
        /// Type: List of StatisticOverride
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public List<StatisticOverride> Overrides { get; set; }

    }
}
