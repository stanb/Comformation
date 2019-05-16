using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset Action
    /// Information needed to run the &quot;containerAction&quot; to produce data set contents.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// ActionName
        /// The name of the data set action by which data set contents are automatically created.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z0-9_]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionName")]
        public Union<string, IntrinsicFunction> ActionName { get; set; }

        /// <summary>
        /// ContainerAction
        /// Information which allows the system to run a containerized application in order to create the data
        /// set contents. The application must be in a Docker container along with any needed support libraries.
        /// Required: No
        /// Type: ContainerAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerAction")]
        public ContainerAction ContainerAction { get; set; }

        /// <summary>
        /// QueryAction
        /// An &quot;SqlQueryDatasetAction&quot; object that uses an SQL query to automatically create data set contents.
        /// Required: No
        /// Type: QueryAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryAction")]
        public QueryAction QueryAction { get; set; }

    }
}
