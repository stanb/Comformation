using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function FileSystemConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-filesystemconfig.html
    /// </summary>
    public class FileSystemConfig
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the Amazon EFS access point that provides access to the file
        /// system.
        /// Required: Yes
        /// Type: String
        /// Maximum: 200
        /// Pattern:
        /// arn:aws[a-zA-Z-]*:elasticfilesystem:[a-z]{2}((-gov)|(-iso(b?)))?-[a-z]+-\d{1}:\d{12}:access-point/fsap-[a-f0-9]{17}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// LocalMountPath
        /// The path where the function can access the file system, starting with /mnt/.
        /// Required: Yes
        /// Type: String
        /// Maximum: 160
        /// Pattern: ^/mnt/[a-zA-Z0-9-_. ]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LocalMountPath")]
        public Union<string, IntrinsicFunction> LocalMountPath { get; set; }

    }
}
