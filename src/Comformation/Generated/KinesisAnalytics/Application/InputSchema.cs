using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application InputSchema
    /// The InputSchema property type describes the format of the data in the streaming source, and how each data
    /// element maps to corresponding columns that are created in the in-application stream in an Amazon Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputschema.html
    /// </summary>
    public class InputSchema
    {

        /// <summary>
        /// RecordEncoding
        /// Specifies the encoding of the records in the streaming source; for example, UTF-8.
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
        /// Type: List of Kinesis Data Analytics Application RecordColumn
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordColumns")]
        public Union<List<RecordColumn>, IntrinsicFunction> RecordColumns { get; set; }

        /// <summary>
        /// RecordFormat
        /// Specifies the format of the records on the streaming source.
        /// Required: Yes
        /// Type: Kinesis Data Analytics Application RecordFormat
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordFormat")]
        public Union<RecordFormat, IntrinsicFunction> RecordFormat { get; set; }

    }
}
