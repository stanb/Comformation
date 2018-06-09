using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket CorsRule
    /// Describes cross-origin access rules for the Amazon S3 Bucket CorsConfiguration property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html
    /// </summary>
    public class CorsRule
    {

        /// <summary>
        /// AllowedHeaders
        /// Headers that are specified in the Access-Control-Request-Headers header. These headers are allowed
        /// in a preflight OPTIONS request. In response to any preflight OPTIONS request, Amazon S3 returns any
        /// requested headers that are allowed.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("AllowedHeaders")]
        public Union<List<string>, IntrinsicFunction> AllowedHeaders { get; set; }

        /// <summary>
        /// AllowedMethods
        /// An HTTP method that you allow the origin to execute. The valid values are GET, PUT, HEAD, POST, and
        /// DELETE.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public Union<List<string>, IntrinsicFunction> AllowedMethods { get; set; }

        /// <summary>
        /// AllowedOrigins
        /// An origin that you allow to send cross-domain requests.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("AllowedOrigins")]
        public Union<List<string>, IntrinsicFunction> AllowedOrigins { get; set; }

        /// <summary>
        /// ExposedHeaders
        /// One or more headers in the response that are accessible to client applications (for example, from a
        /// JavaScript XMLHttpRequest object).
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("ExposedHeaders")]
        public Union<List<string>, IntrinsicFunction> ExposedHeaders { get; set; }

        /// <summary>
        /// Id
        /// A unique identifier for this rule. The value cannot be more than 255 characters.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// MaxAge
        /// The time in seconds that your browser is to cache the preflight response for the specified resource.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("MaxAge")]
        public Union<int, IntrinsicFunction> MaxAge { get; set; }

    }
}
