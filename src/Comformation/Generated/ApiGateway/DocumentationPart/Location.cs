using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DocumentationPart
{
    /// <summary>
    /// AWS::ApiGateway::DocumentationPart Location
    /// The Location property specifies the location of the Amazon API Gateway API entity that the documentation
    /// applies to. Location is a property of the AWS::ApiGateway::DocumentationPart resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-documentationpart-location.html
    /// </summary>
    public class Location
    {

        /// <summary>
        /// Method
        /// The HTTP verb of a method.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Method")]
        public Union<string, IntrinsicFunction> Method { get; set; }

        /// <summary>
        /// Name
        /// The name of the targeted API entity.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Path
        /// The URL path of the target.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// StatusCode
        /// The HTTP status code of a response.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

        /// <summary>
        /// Type
        /// The type of API entity that the documentation content applies to.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
