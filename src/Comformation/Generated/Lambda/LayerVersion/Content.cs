using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.LayerVersion
{
    /// <summary>
    /// AWS Lambda LayerVersion Content
    /// The Content property type specifies the ZIP archive for an AWS Lambda layer version.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-layerversion-content.html
    /// </summary>
    public class Content
    {

        /// <summary>
        /// S3ObjectVersion
        /// For versioned objects, the version of the layer archive object to use.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3ObjectVersion")]
        public Union<string, IntrinsicFunction> S3ObjectVersion { get; set; }

        /// <summary>
        /// S3Bucket
        /// The Amazon S3 bucket of the layer archive.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The Amazon S3 key of the layer archive.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

    }
}
