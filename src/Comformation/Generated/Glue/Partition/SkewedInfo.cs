using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition SkewedInfo
    /// Specifies skewed values in a table. Skewed values are those that occur with very high frequency.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html
    /// </summary>
    public class SkewedInfo
    {

        /// <summary>
        /// SkewedColumnNames
        /// A list of names of columns that contain skewed values.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedColumnNames")]
        public List<Union<string, IntrinsicFunction>> SkewedColumnNames { get; set; }

        /// <summary>
        /// SkewedColumnValues
        /// A list of values that appear so frequently as to be considered skewed.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedColumnValues")]
        public List<Union<string, IntrinsicFunction>> SkewedColumnValues { get; set; }

        /// <summary>
        /// SkewedColumnValueLocationMaps
        /// A mapping of skewed values to the columns that contain them.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedColumnValueLocationMaps")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SkewedColumnValueLocationMaps { get; set; }

    }
}
