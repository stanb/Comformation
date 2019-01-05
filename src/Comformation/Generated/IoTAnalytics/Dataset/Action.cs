using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset Action
    /// The Action property type specifies a list of actions that create data set contents for an AWS IoT Analytics
    /// dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// ActionName
        /// The name of the data set action.
        /// Required: Yes
        /// Type: String
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
        /// Uses an SQL query to automatically create data set contents.
        /// Required: No
        /// Type: QueryAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryAction")]
        public QueryAction QueryAction { get; set; }

    }
}
