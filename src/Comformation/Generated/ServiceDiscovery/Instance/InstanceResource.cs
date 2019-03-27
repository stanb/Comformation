using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Instance
{
    /// <summary>
    /// AWS::ServiceDiscovery::Instance
    /// The AWS::ServiceDiscovery::Instance resource specifies information about a service instance that 		AWS Cloud
    /// Map creates. For more information, see 		Instance 		in the AWS Cloud Map API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            /// InstanceAttributes
            /// 					
            /// A string map that contains attribute keys and values. Supported attribute keys include the
            /// following:
            /// 					
            /// 						 						 						 						 						 					 AWS_ALIAS_DNS_NAME: If you want AWS Cloud Map to create an
            /// Amazon Route&#160;53 alias record that 							routes traffic to an Elastic Load Balancing load balancer,
            /// specify the DNS name that is associated with the 							load balancer. AWS_INSTANCE_CNAME: If the
            /// service configuration includes a CNAME record, the domain name 							that you want Route&#160;53 to
            /// return in response to DNS queries, for example, example. com. This value is required 							if the
            /// service specified by ServiceId includes settings for an CNAME record. AWS_INSTANCE_PORT: The port on
            /// the endpoint that you want AWS Cloud Map to perform health checks on. 							This value is also used
            /// for the port value in an SRV record if the service that you specify includes an SRV record.
            /// 							You can also specify a default port that is applied to all instances in the Service
            /// configuration. 							For more information, see CreateService 							in the AWS Cloud Map API
            /// Reference. AWS_INSTANCE_IPV4: If the service that you specify contains a template for an 							A
            /// record, the IPv4 address that you want AWS Cloud Map to use for the value of the A record.
            /// AWS_INSTANCE_IPV6: If the service that you specify contains a template for an 							AAAA record,
            /// the IPv6 address that you want AWS Cloud Map to use for the value of the AAAA record.
            /// 					
            /// Required: Yes
            /// 					
            /// Type: String map
            /// 					
            /// Update requires: No interruption
            /// 				
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> InstanceAttributes { get; set; }

            /// <summary>
            /// InstanceId
            /// 					
            /// An identifier that you want to associate with the instance. Note the following:
            /// 					
            /// 						 						 					 You can use this value to update an existing instance. To associate a new
            /// instance, you must specify a value that is unique among instances 							that you associate by using
            /// the same service.
            /// 					
            /// Required: Yes
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// ServiceId
            /// 					
            /// The ID of the service that you want to use for settings when you register an instance.
            /// 					
            /// Required: Yes
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceId { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::Instance";

        public InstanceProperties Properties { get; } = new InstanceProperties();

    }
}
