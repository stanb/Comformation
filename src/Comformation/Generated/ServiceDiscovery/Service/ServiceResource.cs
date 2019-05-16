using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service
    /// A complex type that contains information about a service, which defines the configuration of the following
    /// entities:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            /// Description
            /// 		
            /// The description of the service.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// HealthCheckCustomConfig
            /// 		
            /// A complex type that contains information about an optional custom health check.
            /// 		
            /// Important If you specify a health check configuration, you can specify either
            /// HealthCheckCustomConfig or 			HealthCheckConfig but not both.
            /// 	
            /// Required: No
            /// Type: HealthCheckCustomConfig
            /// Update requires: Replacement
            /// </summary>
			public HealthCheckCustomConfig HealthCheckCustomConfig { get; set; }

            /// <summary>
            /// DnsConfig
            /// 		
            /// A complex type that contains information about the Route 53 DNS records that you want AWS Cloud Map
            /// to create when you register an instance.
            /// 	
            /// Required: No
            /// Type: DnsConfig
            /// Update requires: No interruption
            /// </summary>
			public DnsConfig DnsConfig { get; set; }

            /// <summary>
            /// NamespaceId
            /// 		
            /// The ID of the namespace that was used to create the service.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NamespaceId { get; set; }

            /// <summary>
            /// HealthCheckConfig
            /// 		
            /// Public DNS namespaces only. A complex type that contains settings for an optional health check. If
            /// you 			specify settings for a health check, AWS Cloud Map associates the health check with the
            /// records that you specify in 			DnsConfig.
            /// 		
            /// For information about the charges for health checks, see Amazon Route 53 Pricing.
            /// 	
            /// Required: No
            /// Type: HealthCheckConfig
            /// Update requires: No interruption
            /// </summary>
			public HealthCheckConfig HealthCheckConfig { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name of the service.
            /// 	
            /// Required: No
            /// Type: String
            /// Pattern: ((?=^. {1,127}$)^([a-zA-Z0-9_][a-zA-Z0-9-_]{0,61}[a-zA-Z0-9_]|[a-zA-Z0-9])(\.
            /// ([a-zA-Z0-9_][a-zA-Z0-9-_]{0,61}[a-zA-Z0-9_]|[a-zA-Z0-9]))*$)|(^\. $)
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::Service";

        public ServiceProperties Properties { get; } = new ServiceProperties();

    }

	public static class ServiceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
