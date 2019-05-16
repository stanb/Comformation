using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application JSONMappingParameters
    /// For an SQL-based Amazon Kinesis Data Analytics application, provides additional mapping information when JSON
    /// is the record format on the streaming source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-jsonmappingparameters.html
    /// </summary>
    public class JSONMappingParameters
    {

        /// <summary>
        /// RecordRowPath
        /// The path to the top-level parent that contains the records.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowPath")]
        public Union<string, IntrinsicFunction> RecordRowPath { get; set; }

    }
}
