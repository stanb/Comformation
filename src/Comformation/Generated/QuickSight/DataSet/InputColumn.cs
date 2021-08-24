using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet InputColumn
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-inputcolumn.html
    /// </summary>
    public class InputColumn
    {

        /// <summary>
        /// Type
        /// The data type of the column.
        /// Required: Yes
        /// Type: String
        /// Allowed values: BIT | BOOLEAN | DATETIME | DECIMAL | INTEGER | JSON | STRING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Name
        /// The name of this column in the underlying data source.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
