using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application CodeContent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html
    /// </summary>
    public class CodeContent
    {

        /// <summary>
        /// ZipFileContent
        /// The zip-format code for a Flink-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ZipFileContent")]
        public Union<string, IntrinsicFunction> ZipFileContent { get; set; }

        /// <summary>
        /// S3ContentLocation
        /// Information about the Amazon S3 bucket containing the application code.
        /// Required: No
        /// Type: S3ContentLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ContentLocation")]
        public S3ContentLocation S3ContentLocation { get; set; }

        /// <summary>
        /// TextContent
        /// The text-format code for a Flink-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 102400
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextContent")]
        public Union<string, IntrinsicFunction> TextContent { get; set; }

    }
}
