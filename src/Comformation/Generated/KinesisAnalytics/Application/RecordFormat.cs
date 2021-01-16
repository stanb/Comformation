using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// AWS::KinesisAnalytics::Application RecordFormat
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-recordformat.html
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
        /// The type of record format.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CSV | JSON
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordFormatType")]
        public Union<string, IntrinsicFunction> RecordFormatType { get; set; }

    }
}
