using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::ApplicationOutput DestinationSchema
    /// Describes the data format when records are written to the destination in an SQL-based Amazon Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-destinationschema.html
    /// </summary>
    public class DestinationSchema
    {

        /// <summary>
        /// RecordFormatType
        /// Specifies the format of the records on the output stream.
        /// Required: No
        /// Type: String
        /// Allowed Values: CSV | JSON
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordFormatType")]
        public Union<string, IntrinsicFunction> RecordFormatType { get; set; }

    }
}
