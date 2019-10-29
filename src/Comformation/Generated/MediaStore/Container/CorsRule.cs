using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaStore.Container
{
    /// <summary>
    /// AWS::MediaStore::Container CorsRule
    /// A rule for a CORS policy. You can add up to 100 rules to a CORS policy. If more than one rule applies, the
    /// service uses the first applicable rule listed.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html
    /// </summary>
    public class CorsRule
    {

        /// <summary>
        /// AllowedMethods
        /// Identifies an HTTP method that the origin that is specified in the rule is allowed to execute.
        /// Each CORS rule must contain at least one AllowedMethods and one AllowedOrigins element.
        /// Required: No
        /// Type: List of String
        /// Maximum: 4
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public List<Union<string, IntrinsicFunction>> AllowedMethods { get; set; }

        /// <summary>
        /// AllowedOrigins
        /// One or more response headers that you want users to be able to access from their applications (for
        /// example, from a JavaScript XMLHttpRequest object).
        /// Each CORS rule must have at least one AllowedOrigins element. The string value can include only one
        /// wildcard character (*), for example, http://*. example. com. Additionally, you can specify only one
        /// wildcard character to allow cross-origin access for all origins.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedOrigins")]
        public List<Union<string, IntrinsicFunction>> AllowedOrigins { get; set; }

        /// <summary>
        /// ExposeHeaders
        /// One or more headers in the response that you want users to be able to access from their applications
        /// (for example, from a JavaScript XMLHttpRequest object).
        /// This element is optional for each rule.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExposeHeaders")]
        public List<Union<string, IntrinsicFunction>> ExposeHeaders { get; set; }

        /// <summary>
        /// MaxAgeSeconds
        /// The time in seconds that your browser caches the preflight response for the specified resource.
        /// A CORS rule can have only one MaxAgeSeconds element.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxAgeSeconds")]
        public Union<int, IntrinsicFunction> MaxAgeSeconds { get; set; }

        /// <summary>
        /// AllowedHeaders
        /// Specifies which headers are allowed in a preflight OPTIONS request through the
        /// Access-Control-Request-Headers header. Each header name that is specified in
        /// Access-Control-Request-Headers must have a corresponding entry in the rule. Only the headers that
        /// were requested are sent back.
        /// This element can contain only one wildcard character (*).
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedHeaders")]
        public List<Union<string, IntrinsicFunction>> AllowedHeaders { get; set; }

    }
}
