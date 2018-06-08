using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS Glue Table SkewedInfo
    /// The SkewedInfo property type specifies skewed values (values that occur with very high frequency) in an AWS
    /// Glue table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html
    /// </summary>
    public class SkewedInfo
    {

        /// <summary>
        /// SkewedColumnNames
        /// A list of UTF-8 strings that specify the names of columns that contain skewed values.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedColumnNames")]
        public Union<List<string>, IntrinsicFunction> SkewedColumnNames { get; set; }

        /// <summary>
        /// SkewedColumnValues
        /// A list of UTF-8 strings that specify values that appear so frequently that they're considered to be
        /// skewed.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedColumnValues")]
        public Union<List<string>, IntrinsicFunction> SkewedColumnValues { get; set; }

        /// <summary>
        /// SkewedColumnValueLocationMaps
        /// UTF-8 string–to–UTF-8 string key-value pairs that map skewed values to the columns that contain
        /// them.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedColumnValueLocationMaps")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SkewedColumnValueLocationMaps { get; set; }

    }
}
