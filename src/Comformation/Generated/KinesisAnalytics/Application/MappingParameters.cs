using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application MappingParameters
    /// When configuring application input at the time of creating or updating an application, provides additional
    /// mapping information specific to the record format (such as JSON, CSV, or record fields delimited by some
    /// delimiter) on the streaming source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-mappingparameters.html
    /// </summary>
    public class MappingParameters
    {

        /// <summary>
        /// JSONMappingParameters
        /// Provides additional mapping information when JSON is the record format on the streaming source.
        /// Required: No
        /// Type: JSONMappingParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JSONMappingParameters")]
        public JSONMappingParameters JSONMappingParameters { get; set; }

        /// <summary>
        /// CSVMappingParameters
        /// Provides additional mapping information when the record format uses delimiters (for example, CSV).
        /// Required: No
        /// Type: CSVMappingParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CSVMappingParameters")]
        public CSVMappingParameters CSVMappingParameters { get; set; }

    }
}
