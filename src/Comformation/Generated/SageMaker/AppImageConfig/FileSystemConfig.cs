using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.AppImageConfig
{
    /// <summary>
    /// AWS::SageMaker::AppImageConfig FileSystemConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-filesystemconfig.html
    /// </summary>
    public class FileSystemConfig
    {

        /// <summary>
        /// DefaultGid
        /// The default POSIX group ID (GID). If not specified, defaults to 100.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultGid")]
        public Union<int, IntrinsicFunction> DefaultGid { get; set; }

        /// <summary>
        /// DefaultUid
        /// The default POSIX user ID (UID). If not specified, defaults to 1000.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultUid")]
        public Union<int, IntrinsicFunction> DefaultUid { get; set; }

        /// <summary>
        /// MountPath
        /// The path within the image to mount the user&#39;s EFS home directory. The directory should be empty. If
        /// not specified, defaults to /home/sagemaker-user.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^\/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MountPath")]
        public Union<string, IntrinsicFunction> MountPath { get; set; }

    }
}
