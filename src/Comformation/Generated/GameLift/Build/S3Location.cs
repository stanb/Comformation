using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Build
{
    /// <summary>
    /// AWS::GameLift::Build S3Location
    /// Location in Amazon Simple Storage Service (Amazon S3) where build files can be stored for access by Amazon
    /// GameLift. For more details, see the Uploading a Build to Amazon GameLift in the Amazon GameLift Developer
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-build-storagelocation.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// Bucket
        /// Amazon S3 bucket identifier. This is the name of the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// Name of the zip file containing the build files or script files.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RoleArn
        /// Amazon Resource Name (ARN) for an IAM role that allows Amazon GameLift to access the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
