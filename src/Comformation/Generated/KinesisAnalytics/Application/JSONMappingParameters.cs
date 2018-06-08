using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application JSONMappingParameters
    /// The JSONMappingParameters property type specifies additional mapping information when JSON is the record
    /// format on the streaming source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-jsonmappingparameters.html
    /// </summary>
    public class JSONMappingParameters
    {

        /// <summary>
        /// RecordRowPath
        /// The path to the top-level parent that contains the records (e. g. , "$". )
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowPath")]
        public Union<string, IntrinsicFunction> RecordRowPath { get; set; }

    }
}
