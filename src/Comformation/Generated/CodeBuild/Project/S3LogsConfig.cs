using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project S3LogsConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-s3logsconfig.html
    /// </summary>
    public class S3LogsConfig
    {

        /// <summary>
        /// Status
        /// The current status of the S3 build logs. Valid values are:
        /// ENABLED: S3 build logs are enabled for this build project. DISABLED: S3 build logs are not enabled
        /// for this build project.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// EncryptionDisabled
        /// Set to true if you do not want your S3 build log output encrypted. By default S3 build logs are
        /// encrypted.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionDisabled")]
        public Union<bool, IntrinsicFunction> EncryptionDisabled { get; set; }

        /// <summary>
        /// Location
        /// The ARN of an S3 bucket and the path prefix for S3 logs. If your Amazon S3 bucket name is my-bucket,
        /// and your path prefix is build-log, then acceptable formats are my-bucket/build-log or
        /// arn:aws:s3:::my-bucket/build-log.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
