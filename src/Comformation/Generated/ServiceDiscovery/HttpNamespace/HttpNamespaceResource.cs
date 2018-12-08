using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.HttpNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::HttpNamespace
    /// The AWS::ServiceDiscovery::HttpNamespace resource specifies values for an AWS Cloud Map HTTP namespace. 	For
    /// more information, see CreateHttpNamespace 	in the AWS Cloud Map API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-httpnamespace.html
    /// </summary>
    public class HttpNamespaceResource : ResourceBase
    {
        public class HttpNamespaceProperties
        {
            /// <summary>
            /// Description
            /// A description of the namespace.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// A name for the namespace.
            /// Required: Yes
            /// Type: String
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
