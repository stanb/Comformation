using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationOutput DestinationSchema
    /// Describes the data format when records are written to the destination. For more information, see Configuring
    /// Application Output.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-destinationschema.html
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
