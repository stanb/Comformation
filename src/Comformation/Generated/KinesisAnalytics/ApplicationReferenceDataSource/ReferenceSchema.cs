using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource ReferenceSchema
    /// The ReferenceSchema property type specifies the format of the data in the streaming source, and how each data
    /// element maps to corresponding columns created in the in-application stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html
    /// </summary>
    public class ReferenceSchema
    {

        /// <summary>
        /// RecordEncoding
        /// Specifies the encoding of the records in the streaming source; For example, UTF-8.
        /// Required: No
        /// Type: String;
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordEncoding")]
        public Union<string, IntrinsicFunction> RecordEncoding { get; set; }

        /// <summary>
        /// RecordColumns
        /// A list of Amazon Kinesis Data Analytics ApplicationReferenceDataSource RecordColumn objects.
        /// Required: Yes
        /// Type: List of Kinesis Data Analytics ApplicationReferenceDataSource RecordColumn
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordColumns")]
        public Union<List<RecordColumn>, IntrinsicFunction> RecordColumns { get; set; }

        /// <summary>
        /// RecordFormat
        /// Specifies the format of the records on the streaming source.
        /// Required: Yes
        /// Type: Kinesis Data Analytics ApplicationReferenceDataSource RecordFormat
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordFormat")]
        public Union<RecordFormat, IntrinsicFunction> RecordFormat { get; set; }

    }
}
