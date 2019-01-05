using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset QueryAction
    /// The QueryAction property type specifies how to automatically create data set contents using an SQL query for
    /// an AWS IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-queryaction.html
    /// </summary>
    public class QueryAction
    {

        /// <summary>
        /// Filters
        /// Pre-filters applied to message data.
        /// Required: No
        /// Type: List of Filter property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filters")]
        public List<Filter> Filters { get; set; }

        /// <summary>
        /// SqlQuery
        /// An SQL query string.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlQuery")]
        public Union<string, IntrinsicFunction> SqlQuery { get; set; }

    }
}
