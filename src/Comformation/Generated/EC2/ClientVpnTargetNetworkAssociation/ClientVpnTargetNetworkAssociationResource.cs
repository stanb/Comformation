using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnTargetNetworkAssociation
{
    /// <summary>
    /// AWS::EC2::ClientVpnTargetNetworkAssociation
    /// Specifies a target network to associate with a Client VPN endpoint. A target network is a 			subnet in a VPC.
    /// You can associate multiple subnets from the same VPC with a Client VPN 			endpoint. You can associate only one
    /// subnet in each Availability Zone. We recommend that you 			associate at least two subnets to provide
    /// Availability Zone redundancy.
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
