using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS Glue Table Order
    /// The Order property type specifies the sort order of a column in an AWS Glue table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-order.html
    /// </summary>
    public class Order
    {

        /// <summary>
        /// Column
        /// The name of the column. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Column")]
        public Union<string, IntrinsicFunction> Column { get; set; }

        /// <summary>
        /// SortOrder
        /// Indicates whether the column is sorted in ascending order (1) or descending order (0).
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SortOrder")]
        public Union<int, IntrinsicFunction> SortOrder { get; set; }

    }
}
