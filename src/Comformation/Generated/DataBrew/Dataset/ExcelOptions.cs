using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset ExcelOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html
    /// </summary>
    public class ExcelOptions
    {

        /// <summary>
        /// SheetNames
        /// One or more named sheets in the Excel file that will be included in the dataset.
        /// Required: No
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SheetNames")]
        public List<Union<string, IntrinsicFunction>> SheetNames { get; set; }

        /// <summary>
        /// SheetIndexes
        /// One or more sheet numbers in the Excel file that will be included in the dataset.
        /// Required: No
        /// Type: List of Integer
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SheetIndexes")]
        public List<Union<int, IntrinsicFunction>> SheetIndexes { get; set; }

        /// <summary>
        /// HeaderRow
        /// A variable that specifies whether the first row in the file is parsed as the header. If this value
        /// is false, column names are auto-generated.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderRow")]
        public Union<bool, IntrinsicFunction> HeaderRow { get; set; }

    }
}
