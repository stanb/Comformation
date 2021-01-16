using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.LinkAssociation
{
    /// <summary>
    /// AWS::NetworkManager::LinkAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-linkassociation.html
    /// </summary>
    public class LinkAssociationResource : ResourceBase
    {
        public class LinkAssociationProperties
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
            /// DeviceId
            /// The device ID for the link association.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DeviceId { get; set; }

            /// <summary>
            /// LinkId
            /// The ID of the link.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LinkId { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::LinkAssociation";

        public LinkAssociationProperties Properties { get; } = new LinkAssociationProperties();

    }
}
