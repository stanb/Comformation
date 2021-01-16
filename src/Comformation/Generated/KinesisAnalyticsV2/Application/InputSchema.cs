using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application InputSchema
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputschema.html
    /// </summary>
    public class InputSchema
    {

        /// <summary>
        /// RecordEncoding
        /// Specifies the encoding of the records in the streaming source. For example, UTF-8.
        /// Required: No
        /// Type: String
        /// Minimum: 5
        /// Maximum: 5
        /// Pattern: UTF-8
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordEncoding")]
        public Union<string, IntrinsicFunction> RecordEncoding { get; set; }

        /// <summary>
        /// RecordColumns
        /// A list of RecordColumn objects.
        /// Required: Yes
        /// Type: List of RecordColumn
        /// Maximum: 1000
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
