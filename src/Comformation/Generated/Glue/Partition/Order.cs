using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition Order
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-order.html
    /// </summary>
    public class Order
    {

        /// <summary>
        /// Column
        /// The name of the column.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Column")]
        public Union<string, IntrinsicFunction> Column { get; set; }

        /// <summary>
        /// SortOrder
        /// Indicates that the column is sorted in ascending order (== 1), or in descending order (==0).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SortOrder")]
        public Union<int, IntrinsicFunction> SortOrder { get; set; }

    }
}
