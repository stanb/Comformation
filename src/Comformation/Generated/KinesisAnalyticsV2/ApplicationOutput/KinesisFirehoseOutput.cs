using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.ApplicationOutput
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationOutput KinesisFirehoseOutput
    /// The KinesisFirehoseOutput property type specifies a Kinesis Data Firehose delivery stream as the destination
    /// for a SQL-based Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationoutput-kinesisfirehoseoutput.html
    /// </summary>
    public class KinesisFirehoseOutput
    {

        /// <summary>
        /// ResourceARN
        /// The ARN of the destination delivery stream to write to.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

    }
}
