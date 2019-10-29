using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service DnsConfig
    /// A complex type that contains information about the Amazon Route 53 DNS records that you want AWS Cloud Map to
    /// create when you register an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsconfig.html
    /// </summary>
    public class DnsConfig
    {

        /// <summary>
        /// DnsRecords
        /// 		
        /// An array that contains one DnsRecord object for each Route 53 DNS record that you want AWS Cloud Map
        /// to create 			when you register an instance.
        /// 	
        /// Required: Yes
        /// Type: List of DnsRecord
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DnsRecords")]
        public List<DnsRecord> DnsRecords { get; set; }

        /// <summary>
        /// RoutingPolicy
        /// 		
        /// The routing policy that you want to apply to all Route 53 DNS records that AWS Cloud Map creates
        /// when you register an instance and 			specify this service.
        /// 			 			
        /// Note If you want to use this service to register instances that create alias records, specify
        /// WEIGHTED 					for the routing policy.
        /// 		 		
        /// You can specify the following values:
        /// 		 		
        /// MULTIVALUE
        /// 		
        /// If you define a health check for the service and the health check is healthy, Route 53 returns the
        /// applicable value for up to eight instances.
        /// 		
        /// For example, suppose the service includes configurations for one A record and a health check, and
        /// you use the service to register 10 instances. 			Route 53 responds to DNS queries with IP addresses
        /// for up to eight healthy instances. If fewer than eight instances are healthy, Route 53 responds to
        /// 			every DNS query with the IP addresses for all of the healthy instances.
        /// 		
        /// If you don&#39;t define a health check for the service, Route 53 assumes that all instances are healthy
        /// and returns the values for up to eight instances.
        /// 		
        /// For more information about the multivalue routing policy, see 			Multivalue Answer Routing in the
        /// 			Route 53 Developer Guide.
        /// 		 		
        /// WEIGHTED
        /// 		
        /// Route 53 returns the applicable value from one randomly selected instance from among the instances
        /// that you registered using the same service. 			Currently, all records have the same weight, so you
        /// can&#39;t route more or less traffic to any instances.
        /// 		
        /// For example, suppose the service includes configurations for one A record and a health check, and
        /// you use the service to register 10 instances. 			Route 53 responds to DNS queries with the IP
        /// address for one randomly selected instance from among the healthy instances. If no instances are
        /// healthy, 			Route 53 responds to DNS queries as if all of the instances were healthy.
        /// 		
        /// If you don&#39;t define a health check for the service, Route 53 assumes that all instances are healthy
        /// and returns the applicable value for one 			randomly selected instance.
        /// 		
        /// For more information about the weighted routing policy, see 			Weighted Routing in the 			Route 53
        /// Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: MULTIVALUE | WEIGHTED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoutingPolicy")]
        public Union<string, IntrinsicFunction> RoutingPolicy { get; set; }

        /// <summary>
        /// NamespaceId
        /// 		
        /// The ID of the namespace to use for DNS configuration.
        /// 		
        /// Important You must specify a value for NamespaceId either for DnsConfig or for the 				service
        /// properties. 				Don&#39;t specify a value in both places. 			
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("NamespaceId")]
        public Union<string, IntrinsicFunction> NamespaceId { get; set; }

    }
}
