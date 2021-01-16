using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.RestApi
{
    /// <summary>
    /// AWS::ApiGateway::RestApi EndpointConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-restapi-endpointconfiguration.html
    /// </summary>
    public class EndpointConfiguration
    {

        /// <summary>
        /// Types
        /// A list of endpoint types of an API or its custom domain name. Valid values include:
        /// EDGE: For an edge-optimized API and its custom domain name. REGIONAL: For a regional API and its
        /// custom domain name. PRIVATE: For a private API.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Types")]
        public List<Union<string, IntrinsicFunction>> Types { get; set; }

        /// <summary>
        /// VpcEndpointIds
        /// A list of VPC endpoint IDs of an API (AWS::ApiGateway::RestApi) against which to create Route53
        /// ALIASes. It is only supported for PRIVATE endpoint type.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcEndpointIds")]
        public List<Union<string, IntrinsicFunction>> VpcEndpointIds { get; set; }

    }
}
