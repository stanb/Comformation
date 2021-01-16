using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket CorsRule
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
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedHeaders")]
        public List<Union<string, IntrinsicFunction>> AllowedHeaders { get; set; }

        /// <summary>
        /// AllowedMethods
        /// An HTTP method that you allow the origin to run. Valid values are GET, PUT, HEAD, POST, and DELETE.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public List<Union<string, IntrinsicFunction>> AllowedMethods { get; set; }

        /// <summary>
        /// AllowedOrigins
        /// One or more origins you want customers to be able to access the bucket from.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedOrigins")]
        public List<Union<string, IntrinsicFunction>> AllowedOrigins { get; set; }

        /// <summary>
        /// ExposedHeaders
        /// One or more headers in the response that you want customers to be able to access from their
        /// applications (for example, from a JavaScript XMLHttpRequest object).
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExposedHeaders")]
        public List<Union<string, IntrinsicFunction>> ExposedHeaders { get; set; }

        /// <summary>
        /// Id
        /// A unique identifier for this rule. The value must be no more than 255 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// MaxAge
        /// The time in seconds that your browser is to cache the preflight response for the specified resource.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxAge")]
        public Union<int, IntrinsicFunction> MaxAge { get; set; }

    }
}
