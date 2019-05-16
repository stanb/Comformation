using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.HttpNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::HttpNamespace
    /// The HttpNamespace resource is a Cloud Map resource type that contains information about an HTTP namespace.
    /// 			Service instances that you register using an HTTP namespace can be discovered using a DiscoverInstances
    /// request 			but can&#39;t be discovered using DNS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-httpnamespace.html
    /// </summary>
    public class HttpNamespaceResource : ResourceBase
    {
        public class HttpNamespaceProperties
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

        public string Type { get; } = "AWS::ServiceDiscovery::HttpNamespace";

        public HttpNamespaceProperties Properties { get; } = new HttpNamespaceProperties();

    }

	public static class HttpNamespaceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
