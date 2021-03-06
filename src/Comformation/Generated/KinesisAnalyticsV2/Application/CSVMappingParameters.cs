using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application CSVMappingParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-csvmappingparameters.html
    /// </summary>
    public class CSVMappingParameters
    {

        /// <summary>
        /// RecordRowDelimiter
        /// The row delimiter. For example, in a CSV format, &#39;\n&#39; is the typical row delimiter.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowDelimiter")]
        public Union<string, IntrinsicFunction> RecordRowDelimiter { get; set; }

        /// <summary>
        /// RecordColumnDelimiter
        /// The column delimiter. For example, in a CSV format, a comma (&quot;,&quot;) is the typical column delimiter.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordColumnDelimiter")]
        public Union<string, IntrinsicFunction> RecordColumnDelimiter { get; set; }

    }
}
