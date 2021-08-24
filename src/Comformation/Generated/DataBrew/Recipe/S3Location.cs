using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe S3Location
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-s3location.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// Bucket
        /// The Amazon S3 bucket name.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// The unique name of the object in the bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1280
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
