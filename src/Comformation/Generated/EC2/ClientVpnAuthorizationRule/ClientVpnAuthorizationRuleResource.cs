using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnAuthorizationRule
{
    /// <summary>
    /// AWS::EC2::ClientVpnAuthorizationRule
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
            /// The ID of the group to grant access to, for example, the Active Directory group or identity provider
            /// (IdP) group. Required if AuthorizeAllGroups is false or not specified.
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
            /// Indicates whether to grant access to all clients. Specify true to grant all clients who successfully
            /// establish a VPN connection access to the network. Must be set to true if AccessGroupId is not
            /// specified.
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
