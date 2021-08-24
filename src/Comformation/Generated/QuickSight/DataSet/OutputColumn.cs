using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet OutputColumn
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-outputcolumn.html
    /// </summary>
    public class OutputColumn
    {

        /// <summary>
        /// Type
        /// Type.
        /// Required: No
        /// Type: String
        /// Allowed values: DATETIME | DECIMAL | INTEGER | STRING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Description
        /// A description for a column.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Name
        /// A display name for the dataset.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
