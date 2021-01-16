using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset QueryAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html
    /// </summary>
    public class QueryAction
    {

        /// <summary>
        /// Filters
        /// Pre-filters applied to message data.
        /// Required: No
        /// Type: List of Filter
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filters")]
        public List<Filter> Filters { get; set; }

        /// <summary>
        /// SqlQuery
        /// An &quot;SqlQueryDatasetAction&quot; object that uses an SQL query to automatically create data set contents.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlQuery")]
        public Union<string, IntrinsicFunction> SqlQuery { get; set; }

    }
}
