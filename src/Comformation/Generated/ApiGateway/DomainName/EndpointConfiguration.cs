using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DomainName
{
    /// <summary>
    /// AWS::ApiGateway::DomainName EndpointConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-endpointconfiguration.html
    /// </summary>
    public class EndpointConfiguration
    {

        /// <summary>
        /// Types
        /// A list of endpoint types of an API or its custom domain name. For an edge-optimized API and its
        /// custom domain name, the endpoint type is EDGE. For a regional API and its custom domain name, the
        /// endpoint type is REGIONAL.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Types")]
        public List<Union<string, IntrinsicFunction>> Types { get; set; }

    }
}
