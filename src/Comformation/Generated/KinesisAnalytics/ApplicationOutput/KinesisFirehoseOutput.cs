using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationOutput
{
    /// <summary>
    /// Amazon Kinesis Data Analytics ApplicationOutput KinesisFirehoseOutput
    /// The KinesisFirehoseOutput property type specifies an Amazon Kinesis Data Firehose delivery stream as the
    /// destination when you are configuring application output.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationoutput-kinesisfirehoseoutput.html
    /// </summary>
    public class KinesisFirehoseOutput
    {

        /// <summary>
        /// ResourceARN
        /// The Amazon Resource Name (ARN) of the destination Amazon Kinesis Data Firehose delivery stream to
        /// write to.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the IAM role that Amazon Kinesis Data Analytics can assume to write to the destination
        /// stream on your behalf.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
