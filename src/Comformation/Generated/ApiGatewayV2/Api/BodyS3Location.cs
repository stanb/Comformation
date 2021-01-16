using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Api
{
    /// <summary>
    /// AWS::ApiGatewayV2::Api BodyS3Location
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-api-bodys3location.html
    /// </summary>
    public class BodyS3Location
    {

        /// <summary>
        /// Etag
        /// The Etag of the S3 object.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Etag")]
        public Union<string, IntrinsicFunction> Etag { get; set; }

        /// <summary>
        /// Bucket
        /// The S3 bucket that contains the OpenAPI definition to import. Required if you specify a
        /// BodyS3Location for an API.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Version
        /// The version of the S3 object.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Key
        /// The key of the S3 object. Required if you specify a BodyS3Location for an API.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
