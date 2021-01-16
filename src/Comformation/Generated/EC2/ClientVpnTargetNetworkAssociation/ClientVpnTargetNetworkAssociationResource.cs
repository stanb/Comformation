using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnTargetNetworkAssociation
{
    /// <summary>
    /// AWS::EC2::ClientVpnTargetNetworkAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpntargetnetworkassociation.html
    /// </summary>
    public class ClientVpnTargetNetworkAssociationResource : ResourceBase
    {
        public class ClientVpnTargetNetworkAssociationProperties
        {
            /// <summary>
            /// ClientVpnEndpointId
            /// 		
            /// The ID of the Client VPN endpoint.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClientVpnEndpointId { get; set; }

            /// <summary>
            /// SubnetId
            /// 		
            /// The ID of the subnet to associate with the Client VPN endpoint.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::ClientVpnTargetNetworkAssociation";

        public ClientVpnTargetNetworkAssociationProperties Properties { get; } = new ClientVpnTargetNetworkAssociationProperties();

    }
}
