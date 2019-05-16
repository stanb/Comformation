using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationReferenceDataSource CSVMappingParameters
    /// Provides additional mapping information when the record format uses delimiters, such as CSV. For example, the
    /// following sample records use CSV format, where the records use the &#39;\n&#39; as the row delimiter and a comma (&quot;,&quot;)
    /// as the column delimiter:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-csvmappingparameters.html
    /// </summary>
    public class CSVMappingParameters
    {

        /// <summary>
        /// RecordRowDelimiter
        /// Row delimiter. For example, in a CSV format, &#39;\n&#39; is the typical row delimiter.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowDelimiter")]
        public Union<string, IntrinsicFunction> RecordRowDelimiter { get; set; }

        /// <summary>
        /// RecordColumnDelimiter
        /// Column delimiter. For example, in a CSV format, a comma (&quot;,&quot;) is the typical column delimiter.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordColumnDelimiter")]
        public Union<string, IntrinsicFunction> RecordColumnDelimiter { get; set; }

    }
}
