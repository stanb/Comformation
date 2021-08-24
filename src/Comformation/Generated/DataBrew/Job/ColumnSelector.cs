using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job ColumnSelector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnselector.html
    /// </summary>
    public class ColumnSelector
    {

        /// <summary>
        /// Regex
        /// A regular expression for selecting a column from a dataset.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regex")]
        public Union<string, IntrinsicFunction> Regex { get; set; }

        /// <summary>
        /// Name
        /// The name of a column from a dataset.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
