using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application KinesisFirehoseInput
    /// The KinesisFirehoseInput property type identifies an Amazon Kinesis Data Firehose delivery stream as the
    /// streaming source for an Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-kinesisfirehoseinput.html
    /// </summary>
    public class KinesisFirehoseInput
    {

        /// <summary>
        /// ResourceARN
        /// The Amazon Resource Name (ARN) of the input Kinesis Data Firehose delivery stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the IAM role that Kinesis Data Analytics can assume to access the stream on your behalf.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
