using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application CodeContent
    /// The CodeContent property type specifies either the application code, or the location of the application code,
    /// for a Java-based Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-codecontent.html
    /// </summary>
    public class CodeContent
    {

        /// <summary>
        /// ZipFileContent
        /// The zip-format code for a Java-based Kinesis Data Analytics application.
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
        /// The text-format code for a Java-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextContent")]
        public Union<string, IntrinsicFunction> TextContent { get; set; }

    }
}
