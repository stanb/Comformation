using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Build
{
    /// <summary>
    /// Amazon GameLift Build StorageLocation
    /// StorageLocation is a property of the AWS::GameLift::Build resource that specifies the location of an Amazon
    /// GameLift (GameLift) build package files, such as the game server binaries. For more information, see Uploading
    /// a Build to Amazon GameLift in the Amazon GameLift Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-build-storagelocation.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// Bucket
        /// The S3 bucket where the GameLift build package files are stored.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// The prefix (folder name) where the GameLift build package files are located.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RoleArn
        /// An AWS Identity and Access Management (IAM) role Amazon Resource Name (ARN) that GameLift can assume
        /// to retrieve the build package files from Amazon Simple Storage Service (Amazon S3).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
