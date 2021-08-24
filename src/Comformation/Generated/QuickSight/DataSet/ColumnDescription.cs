using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet ColumnDescription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-columndescription.html
    /// </summary>
    public class ColumnDescription
    {

        /// <summary>
        /// Text
        /// The text of a description for a column.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Text")]
        public Union<string, IntrinsicFunction> Text { get; set; }

    }
}
