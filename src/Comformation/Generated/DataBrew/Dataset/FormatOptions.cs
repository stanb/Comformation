using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset FormatOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html
    /// </summary>
    public class FormatOptions
    {

        /// <summary>
        /// Json
        /// Options that define how JSON input is to be interpreted by DataBrew.
        /// Required: No
        /// Type: JsonOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Json")]
        public JsonOptions Json { get; set; }

        /// <summary>
        /// Excel
        /// Options that define how Excel input is to be interpreted by DataBrew.
        /// Required: No
        /// Type: ExcelOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Excel")]
        public ExcelOptions Excel { get; set; }

        /// <summary>
        /// Csv
        /// Options that define how CSV input is to be interpreted by DataBrew.
        /// Required: No
        /// Type: CsvOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Csv")]
        public CsvOptions Csv { get; set; }

    }
}
