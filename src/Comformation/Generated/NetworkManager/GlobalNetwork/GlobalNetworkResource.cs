using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.GlobalNetwork
{
    /// <summary>
    /// AWS::NetworkManager::GlobalNetwork
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-globalnetwork.html
    /// </summary>
    public class GlobalNetworkResource : ResourceBase
    {
        public class GlobalNetworkProperties
        {
            /// <summary>
            /// Description
            /// A description of the global network.
            /// Length Constraints: Maximum length of 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the global network.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::GlobalNetwork";

        public GlobalNetworkProperties Properties { get; } = new GlobalNetworkProperties();

    }

    public static class GlobalNetworkAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
