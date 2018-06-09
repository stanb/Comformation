using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.RestApi
{
    /// <summary>
    /// Amazon API Gateway RestApi S3Location
    /// S3Location is a property of the AWS::ApiGateway::RestApi resource that specifies the Amazon Simple Storage
    /// Service (Amazon S3) location of a OpenAPI (formerly Swagger) file that defines a set of RESTful APIs in JSON
    /// or YAML for an Amazon API Gateway (API Gateway) RestApi.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-restapi-bodys3location.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// Bucket
        /// The name of the S3 bucket where the OpenAPI file is stored.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// ETag
        /// The Amazon S3 ETag (a file checksum) of the OpenAPI file. If you don&#39;t specify a value, API Gateway
        /// skips ETag validation of your OpenAPI file.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ETag")]
        public Union<string, IntrinsicFunction> ETag { get; set; }

        /// <summary>
        /// Key
        /// The file name of the OpenAPI file (Amazon S3 object name).
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Version
        /// For versioning-enabled buckets, a specific version of the OpenAPI file.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
