using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.CustomerGatewayAssociation
{
    /// <summary>
    /// AWS::NetworkManager::CustomerGatewayAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-customergatewayassociation.html
    /// </summary>
    public class CustomerGatewayAssociationResource : ResourceBase
    {
        public class CustomerGatewayAssociationProperties
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
            /// CustomerGatewayArn
            /// The Amazon Resource Name (ARN) of the customer gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomerGatewayArn { get; set; }

            /// <summary>
            /// DeviceId
            /// The ID of the device.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DeviceId { get; set; }

            /// <summary>
            /// LinkId
            /// The ID of the link.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LinkId { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::CustomerGatewayAssociation";

        public CustomerGatewayAssociationProperties Properties { get; } = new CustomerGatewayAssociationProperties();

    }
}
