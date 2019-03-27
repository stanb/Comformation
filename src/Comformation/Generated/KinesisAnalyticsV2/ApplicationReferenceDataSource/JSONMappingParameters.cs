using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationReferenceDataSource
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationReferenceDataSource JSONMappingParameters
    /// The JSONMappingParameters property type specifies additional mapping information when JSON is the record
    /// format on the reference source for a SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationreferencedatasource-jsonmappingparameters.html
    /// </summary>
    public class JSONMappingParameters
    {

        /// <summary>
        /// RecordRowPath
        /// The path to the top-level parent that contains the records.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowPath")]
        public Union<string, IntrinsicFunction> RecordRowPath { get; set; }

    }
}
