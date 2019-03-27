using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service
    /// The AWS::ServiceDiscovery::Service resource defines a template that your application uses to register service
    /// instances. 		For more information, see CreateService 		in the AWS Cloud Map API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            /// Description
            /// 					
            /// A description for the service.
            /// 					
            /// Required: No
            /// 					
            /// Type: String
            /// 					
            /// Update requires: No interruption
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// HealthCheckCustomConfig
            /// 					
            /// Specifies information about an optional custom health check.
            /// 					
            /// If you specify a health check configuration, you can specify either HealthCheckCustomConfig or
            /// HealthCheckConfig but not both.
            /// 					
            /// Required: No
            /// 					
            /// Type: HealthCheckCustomConfig
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public HealthCheckCustomConfig HealthCheckCustomConfig { get; set; }

            /// <summary>
            /// DnsConfig
            /// 					
            /// An optional complex type that contains information about the DNS records that you want AWS Cloud Map
            /// to create 						when you register an instance.
            /// 					
            /// Required: No
            /// 					
            /// Type: DnsConfig
            /// 					
            /// Update requires: No interruption
            /// 				
            /// </summary>
			public DnsConfig DnsConfig { get; set; }

            /// <summary>
            /// NamespaceId
            /// 					
            /// The ID of the namespace that you want to use to create the service.
            /// 					
            /// 						Required: No
            /// 					
            /// 						Type: String
            /// 					
            /// 						Update requires: Replacement 					
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> NamespaceId { get; set; }

            /// <summary>
            /// HealthCheckConfig
            /// 					
            /// A complex type that contains settings for an optional Route&#160;53 health check. If you specify settings
            /// for a health check, 						AWS Cloud Map associates the health check with all the records that you
            /// specify in DnsConfig.
            /// 					
            /// If you specify a health check configuration, you can specify either HealthCheckCustomConfig or
            /// HealthCheckConfig but not both.
            /// 					
            /// Required: No
            /// 					
            /// Type: HealthCheckConfig
            /// 					
            /// Update requires: No interruption
            /// 				
            /// </summary>
			public HealthCheckConfig HealthCheckConfig { get; set; }

            /// <summary>
            /// Name
            /// 					
            /// The name that you want to assign to the service.
            /// 					
            /// Required: No
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
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
