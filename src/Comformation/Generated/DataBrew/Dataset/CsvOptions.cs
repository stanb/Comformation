using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset CsvOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-csvoptions.html
    /// </summary>
    public class CsvOptions
    {

        /// <summary>
        /// Delimiter
        /// A single character that specifies the delimiter being used in the CSV file.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

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
