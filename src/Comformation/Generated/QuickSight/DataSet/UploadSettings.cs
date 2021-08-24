using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet UploadSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html
    /// </summary>
    public class UploadSettings
    {

        /// <summary>
        /// ContainsHeader
        /// Whether the file has a header row, or the files each have a header row.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainsHeader")]
        public Union<bool, IntrinsicFunction> ContainsHeader { get; set; }

        /// <summary>
        /// TextQualifier
        /// Text qualifier.
        /// Required: No
        /// Type: String
        /// Allowed values: DOUBLE_QUOTE | SINGLE_QUOTE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextQualifier")]
        public Union<string, IntrinsicFunction> TextQualifier { get; set; }

        /// <summary>
        /// Format
        /// File format.
        /// Required: No
        /// Type: String
        /// Allowed values: CLF | CSV | ELF | JSON | TSV | XLSX
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// StartFromRow
        /// A row number to start reading data from.
        /// Required: No
        /// Type: Double
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartFromRow")]
        public Union<double, IntrinsicFunction> StartFromRow { get; set; }

        /// <summary>
        /// Delimiter
        /// The delimiter between values in the file.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

    }
}
