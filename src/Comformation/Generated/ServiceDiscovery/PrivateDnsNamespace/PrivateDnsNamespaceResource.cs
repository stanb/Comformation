using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PrivateDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PrivateDnsNamespace
    /// Creates a private namespace based on DNS, which will be visible only inside a specified Amazon VPC. The
    /// namespace defines 			your service naming scheme. For example, if you name your namespace example. com and name
    /// your service backend, 			the resulting DNS name for the service will be backend. example. com. For the current
    /// limit on the number of namespaces that you can 			create using the same AWS account, see 			AWS Cloud Map
    /// Limits in the 			AWS Cloud Map Developer Guide.
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
            /// Type: String
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Vpc
            /// 		
            /// The ID of the Amazon VPC that you want to associate the namespace with.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Vpc { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name that you want to assign to this namespace. When you create a private DNS namespace, AWS
            /// Cloud Map automatically creates an 			Amazon Route 53 private hosted zone that has the same name as
            /// the namespace.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::PrivateDnsNamespace";

        public PrivateDnsNamespaceProperties Properties { get; } = new PrivateDnsNamespaceProperties();

    }

	public static class PrivateDnsNamespaceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
