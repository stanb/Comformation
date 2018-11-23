using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource RecordFormat
    /// The RecordFormat property type specifies the record format and relevant mapping information that should be
    /// applied to schematize the records on the stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-recordformat.html
    /// </summary>
    public class RecordFormat
    {

        /// <summary>
        /// MappingParameters
        /// When configuring application input at the time of creating or updating an application, provides
        /// additional mapping information specific to the record format (such as JSON, CSV, or record fields
        /// delimited by some delimiter) on the streaming source.
        /// Required: No
        /// Type: MappingParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MappingParameters")]
        public MappingParameters MappingParameters { get; set; }

        /// <summary>
        /// RecordFormatType
        /// The type of record format (CSV or JSON).
        /// Required: Yes
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordFormatType")]
        public Union<string, IntrinsicFunction> RecordFormatType { get; set; }

    }
}
