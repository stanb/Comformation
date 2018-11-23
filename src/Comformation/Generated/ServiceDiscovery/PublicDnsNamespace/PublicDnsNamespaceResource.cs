using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PublicDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PublicDnsNamespace
    /// The AWS::ServiceDiscovery::PublicDnsNamespace resource specifies information about 		a public namespace for
    /// Amazon Route&#160;53. Use a public namespace when you want to route internet traffic to your resources. 		For more
    /// information, see CreatePublicDnsNamespace 		in the Amazon Route&#160;53 API Reference.
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
            /// 					
            /// Type: String
            /// 					
            /// Update requires: Replacement
            /// 				
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// 					
            /// The name that you want to assign to this namespace. When you create a namespace, Route&#160;53
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

        public string Type { get; } = "AWS::ServiceDiscovery::PublicDnsNamespace";

        public PublicDnsNamespaceProperties Properties { get; } = new PublicDnsNamespaceProperties();

    }

	public static class PublicDnsNamespaceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
