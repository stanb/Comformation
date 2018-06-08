using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PrivateDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PrivateDnsNamespace
    /// The AWS::ServiceDiscovery::PrivateDnsNamespace resource specifies information about 		a private namespace for
    /// Amazon Route 53. Use a private namespace when you want to route traffic inside an Amazon VPC. 		For more
    /// information, see CreatePrivateDnsNamespace 		in the Amazon Route 53 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html
    /// </summary>
    public class PrivateDnsNamespaceResource : ResourceBase
    {
        public class PrivateDnsNamespaceProperties
        {
            /// <summary>
            /// Description
            /// 					
            /// A description for the namespace.
            /// 					
            /// Required: No
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Vpc
            /// 					
            /// The ID of the Amazon VPC that you want to associate the namespace with.
            /// 					
            /// Required: Yes
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> Vpc { get; set; }

            /// <summary>
            /// Name
            /// 					
            /// The name that you want to assign to this namespace. When you create a namespace, Route 53
            /// automatically creates a 						hosted zone that has the same name as the namespace.
            /// 					
            /// Required: Yes
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceDiscovery::PrivateDnsNamespace";
        
        public PrivateDnsNamespaceProperties Properties { get; } = new PrivateDnsNamespaceProperties();
    }

	public static class PrivateDnsNamespaceAttributes
	{
        public static readonly ResourceAttribute<string> Id = new ResourceAttribute<string>("Id");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
