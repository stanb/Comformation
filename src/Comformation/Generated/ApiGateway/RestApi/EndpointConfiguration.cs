using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.RestApi
{
    /// <summary>
    /// Amazon API Gateway RestApi EndpointConfiguration
    /// The EndpointConfiguration property type specifies the endpoint types of an Amazon API Gateway REST API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-restapi-endpointconfiguration.html
    /// </summary>
    public class EndpointConfiguration
    {

        /// <summary>
        /// Types
        /// A list of endpoint types of an API or its custom domain name. Valid values include:
        /// EDGE: For an edge-optimized API and its custom domain name. REGIONAL: For a regional API and its
        /// custom domain name. PRIVATE : For a private API and its custom domain name.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Types")]
        public List<Union<string, IntrinsicFunction>> Types { get; set; }

    }
}
