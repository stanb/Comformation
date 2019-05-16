using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PublicDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PublicDnsNamespace
    /// Creates a public namespace based on DNS, which will be visible on the internet. The namespace defines your
    /// service naming scheme. 			For example, if you name your namespace example. com and name your service backend,
    /// the resulting DNS name 			for the service will be backend. example. com. For the current limit on the number
    /// of namespaces that you can 			create using the same AWS account, see 			AWS Cloud Map Limits in the 			AWS
    /// Cloud Map Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html
    /// </summary>
    public class PublicDnsNamespaceResource : ResourceBase
    {
        public class PublicDnsNamespaceProperties
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
            /// Name
            /// 		
            /// The name that you want to assign to this namespace.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::PublicDnsNamespace";

        public PublicDnsNamespaceProperties Properties { get; } = new PublicDnsNamespaceProperties();

    }

	public static class PublicDnsNamespaceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
