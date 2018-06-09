using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service
    /// The AWS::ServiceDiscovery::Service resource defines a template for up to five records and an 		optional health
    /// check that you want Amazon Route&#160;53 to create when you register an instance. For more information, see
    /// 		CreateService 		in the Amazon Route&#160;53 API Reference.
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
            /// DnsConfig
            /// 					
            /// A complex type that contains information about the resource record sets that you want Route&#160;53 to
            /// create 						when you register an instance.
            /// 					
            /// Required: Yes
            /// 					
            /// Type: Amazon Route&#160;53 ServiceDiscovery DnsConfig
            /// 					
            /// Update requires: No interruption
            /// 				
            /// </summary>
			public Union<DnsConfig, IntrinsicFunction> DnsConfig { get; set; }

            /// <summary>
            /// HealthCheckConfig
            /// 					
            /// A complex type that contains settings for an optional health check. If you specify settings for a
            /// health check, 						Route&#160;53 associates the health check with all the resource record sets that you
            /// specify in DnsConfig.
            /// 					
            /// Required: No
            /// 					
            /// Type: Amazon Route&#160;53 ServiceDiscovery HealthCheckConfig
            /// 					
            /// Update requires: No interruption
            /// 				
            /// </summary>
			public Union<HealthCheckConfig, IntrinsicFunction> HealthCheckConfig { get; set; }

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
        public static readonly ResourceAttribute<string> Id = new ResourceAttribute<string>("Id");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
