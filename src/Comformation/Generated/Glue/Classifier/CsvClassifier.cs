using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    /// AWS::Glue::Classifier CsvClassifier
    /// A classifier for custom CSV content.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html
    /// </summary>
    public class CsvClassifier
    {

        /// <summary>
        /// QuoteSymbol
        /// A custom symbol to denote what combines content into a single column value. It must be different
        /// from the column delimiter.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QuoteSymbol")]
        public Union<string, IntrinsicFunction> QuoteSymbol { get; set; }

        /// <summary>
        /// ContainsHeader
        /// Indicates whether the CSV file contains a header.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainsHeader")]
        public Union<string, IntrinsicFunction> ContainsHeader { get; set; }

        /// <summary>
        /// Delimiter
        /// A custom symbol to denote what separates each column entry in the row.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

        /// <summary>
        /// Header
        /// A list of strings representing column names.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Header")]
        public List<Union<string, IntrinsicFunction>> Header { get; set; }

        /// <summary>
        /// AllowSingleColumn
        /// Enables the processing of files that contain only one column.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowSingleColumn")]
        public Union<bool, IntrinsicFunction> AllowSingleColumn { get; set; }

        /// <summary>
        /// DisableValueTrimming
        /// Specifies not to trim values before identifying the type of column values. The default value is
        /// true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableValueTrimming")]
        public Union<bool, IntrinsicFunction> DisableValueTrimming { get; set; }

        /// <summary>
        /// Name
        /// The name of the classifier.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
