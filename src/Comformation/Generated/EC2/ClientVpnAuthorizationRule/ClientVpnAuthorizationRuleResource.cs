using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnAuthorizationRule
{
    /// <summary>
    /// AWS::EC2::ClientVpnAuthorizationRule
    /// Specifies an ingress authorization rule to add to a Client VPN endpoint. Ingress authorization 			rules act as
    /// firewall rules that grant access to networks. You must configure ingress authorization 			rules to enable
    /// clients to access resources in AWS or on-premises networks.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html
    /// </summary>
    public class ClientVpnAuthorizationRuleResource : ResourceBase
    {
        public class ClientVpnAuthorizationRuleProperties
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
            /// Description
            /// 		
            /// A brief description of the authorization rule.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AccessGroupId
            /// 		
            /// The ID of the Active Directory group to grant access.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AccessGroupId { get; set; }

            /// <summary>
            /// TargetNetworkCidr
            /// 		
            /// The IPv4 address range, in CIDR notation, of the network for which access is being authorized.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TargetNetworkCidr { get; set; }

            /// <summary>
            /// AuthorizeAllGroups
            /// 		
            /// Indicates whether to grant access to all clients. Use true to grant all clients 			who successfully
            /// establish a VPN connection access to the network.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> AuthorizeAllGroups { get; set; }

        }

        public string Type { get; } = "AWS::EC2::ClientVpnAuthorizationRule";

        public ClientVpnAuthorizationRuleProperties Properties { get; } = new ClientVpnAuthorizationRuleProperties();

    }
}
