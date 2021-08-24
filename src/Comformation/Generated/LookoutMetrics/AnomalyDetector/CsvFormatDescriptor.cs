using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector CsvFormatDescriptor
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-csvformatdescriptor.html
    /// </summary>
    public class CsvFormatDescriptor
    {

        /// <summary>
        /// FileCompression
        /// The level of compression of the source CSV file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileCompression")]
        public Union<string, IntrinsicFunction> FileCompression { get; set; }

        /// <summary>
        /// Charset
        /// The character set in which the source CSV file is written.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Charset")]
        public Union<string, IntrinsicFunction> Charset { get; set; }

        /// <summary>
        /// Delimiter
        /// The character used to delimit the source CSV file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

        /// <summary>
        /// HeaderList
        /// A list of the source CSV file&#39;s headers, if any.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderList")]
        public List<Union<string, IntrinsicFunction>> HeaderList { get; set; }

        /// <summary>
        /// QuoteSymbol
        /// The character used as a quote character.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QuoteSymbol")]
        public Union<string, IntrinsicFunction> QuoteSymbol { get; set; }

        /// <summary>
        /// ContainsHeader
        /// Whether or not the source CSV file contains a header.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainsHeader")]
        public Union<bool, IntrinsicFunction> ContainsHeader { get; set; }

    }
}
