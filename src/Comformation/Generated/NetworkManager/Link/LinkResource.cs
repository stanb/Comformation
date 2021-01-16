using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.Link
{
    /// <summary>
    /// AWS::NetworkManager::Link
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html
    /// </summary>
    public class LinkResource : ResourceBase
    {
        public class LinkProperties
        {
            /// <summary>
            /// GlobalNetworkId
            /// The ID of the global network.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalNetworkId { get; set; }

            /// <summary>
            /// SiteId
            /// The ID of the site.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SiteId { get; set; }

            /// <summary>
            /// Bandwidth
            /// The bandwidth for the link.
            /// Required: Yes
            /// Type: Bandwidth
            /// Update requires: No interruption
            /// </summary>
            public Bandwidth Bandwidth { get; set; }

            /// <summary>
            /// Provider
            /// The provider of the link.
            /// Constraints: Cannot include the following characters: | \ ^
            /// Length Constraints: Maximum length of 128 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Provider { get; set; }

            /// <summary>
            /// Description
            /// A description of the link.
            /// Length Constraints: Maximum length of 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the link.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of the link.
            /// Constraints: Cannot include the following characters: | \ ^
            /// Length Constraints: Maximum length of 128 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::Link";

        public LinkProperties Properties { get; } = new LinkProperties();

    }

    public static class LinkAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LinkArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LinkArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LinkId = new ResourceAttribute<Union<string, IntrinsicFunction>>("LinkId");
    }
}
