using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application InputSchema
    /// The InputSchema property type for a SQL-based Kinesis Data Analytics application to describe the format of the
    /// data in the streaming source, and how each data element maps to corresponding columns created in the
    /// in-application stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputschema.html
    /// </summary>
    public class InputSchema
    {

        /// <summary>
        /// RecordEncoding
        /// Specifies the encoding of the records in the streaming source. For example, UTF-8.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordEncoding")]
        public Union<string, IntrinsicFunction> RecordEncoding { get; set; }

        /// <summary>
        /// RecordColumns
        /// A list of RecordColumn objects.
        /// Required: Yes
        /// Type: List of RecordColumn
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordColumns")]
        public List<RecordColumn> RecordColumns { get; set; }

        /// <summary>
        /// RecordFormat
        /// Specifies the format of the records on the streaming source.
        /// Required: Yes
        /// Type: RecordFormat
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordFormat")]
        public RecordFormat RecordFormat { get; set; }

    }
}
