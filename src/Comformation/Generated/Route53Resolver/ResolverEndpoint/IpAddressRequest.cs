using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverEndpoint
{
    /// <summary>
    /// Amazon Route&#160;53 ResolverEndpoint IpAddressRequest
    /// The 	IpAddressRequest property type specifies the subnets and IP addresses in your VPC that you want DNS
    /// queries 	to pass through on the way from your VPCs to your network (for outbound endpoints) or on the way from
    /// your network to your VPCs 	(for inbound resolver endpoints).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html
    /// </summary>
    public class IpAddressRequest
    {

        /// <summary>
        /// Ip
        /// 	
        /// The IP address that you want to use for DNS queries.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ip")]
        public Union<string, IntrinsicFunction> Ip { get; set; }

        /// <summary>
        /// SubnetId
        /// 	
        /// The subnet that contains the IP address.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
