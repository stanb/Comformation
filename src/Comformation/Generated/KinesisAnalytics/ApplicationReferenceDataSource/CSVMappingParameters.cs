using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource CSVMappingParameters
    /// In AWS CloudFormation, use the CSVMappingParameters property to specify additional mapping information when
    /// the record format uses delimiters, such as CSV.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-csvmappingparameters.html
    /// </summary>
    public class CSVMappingParameters
    {

        /// <summary>
        /// RecordRowDelimiter
        /// The row delimiter. For example, in a CSV format, "\n" is the typical row delimiter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowDelimiter")]
        public Union<string, IntrinsicFunction> RecordRowDelimiter { get; set; }

        /// <summary>
        /// RecordColumnDelimiter
        /// The column delimiter. For example, in a CSV format, a comma (",") is the typical column delimiter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordColumnDelimiter")]
        public Union<string, IntrinsicFunction> RecordColumnDelimiter { get; set; }

    }
}
