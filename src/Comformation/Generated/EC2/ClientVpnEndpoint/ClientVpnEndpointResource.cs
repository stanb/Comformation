using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html
    /// </summary>
    public class ClientVpnEndpointResource : ResourceBase
    {
        public class ClientVpnEndpointProperties
        {
            /// <summary>
            /// ClientCidrBlock
            /// 		
            /// The IPv4 address range, in CIDR notation, from which to assign client IP addresses. The address
            /// range cannot overlap with the local CIDR of the VPC in which the associated subnet is located, or
            /// the routes that you add manually. The address range cannot be changed after the Client VPN endpoint
            /// has been created. The CIDR block should be /22 or greater.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClientCidrBlock { get; set; }

            /// <summary>
            /// ClientConnectOptions
            /// The options for managing connection authorization for new client connections.
            /// Required: No
            /// Type: ClientConnectOptions
            /// Update requires: No interruption
            /// </summary>
            public ClientConnectOptions ClientConnectOptions { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// A brief description of the Client VPN endpoint.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// TagSpecifications
            /// 		
            /// The tags to apply to the Client VPN endpoint during creation.
            /// 	
            /// Required: No
            /// Type: List of TagSpecification
            /// Update requires: Replacement
            /// </summary>
            public List<TagSpecification> TagSpecifications { get; set; }

            /// <summary>
            /// AuthenticationOptions
            /// 		
            /// Information about the authentication method to be used to authenticate clients.
            /// 	
            /// Required: Yes
            /// Type: List of ClientAuthenticationRequest
            /// Update requires: Replacement
            /// </summary>
            public List<ClientAuthenticationRequest> AuthenticationOptions { get; set; }

            /// <summary>
            /// ServerCertificateArn
            /// 		
            /// The ARN of the server certificate. For more information, see 			the AWS Certificate Manager User
            /// Guide.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServerCertificateArn { get; set; }

            /// <summary>
            /// DnsServers
            /// 		
            /// Information about the DNS servers to be used for DNS resolution. A Client VPN endpoint can 			have
            /// up to two DNS servers. If no DNS server is specified, the DNS address configured on the device is
            /// used for the DNS server.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> DnsServers { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// The IDs of one or more security groups to apply to the target network. You must also specify the ID
            /// of the VPC that contains the security groups.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// ConnectionLogOptions
            /// 		
            /// Information about the client connection logging options.
            /// 		
            /// If you enable client connection logging, data about client connections is sent to a 			Cloudwatch
            /// Logs log stream. The following information is logged:
            /// 		
            /// 			 			 			 			 		 Client connection requests Client connection results (successful and
            /// unsuccessful) Reasons for unsuccessful client connection requests Client connection termination time
            /// 	
            /// Required: Yes
            /// Type: ConnectionLogOptions
            /// Update requires: No interruption
            /// </summary>
            public ConnectionLogOptions ConnectionLogOptions { get; set; }

            /// <summary>
            /// SplitTunnel
            /// 		
            /// Indicates whether split-tunnel is enabled on the AWS Client VPN endpoint.
            /// 		
            /// By default, split-tunnel on a VPN endpoint is disabled.
            /// 		
            /// For information about split-tunnel VPN endpoints, see Split-Tunnel AWS Client VPN Endpoint in the
            /// AWS 				Client VPN Administrator Guide.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> SplitTunnel { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC to associate with the Client VPN endpoint. If no security group IDs are specified
            /// in the request, the default security group for the VPC is applied.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// SelfServicePortal
            /// Specify whether to enable the self-service portal for the Client VPN endpoint.
            /// Default Value: enabled
            /// Required: No
            /// Type: String
            /// Allowed values: disabled | enabled
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SelfServicePortal { get; set; }

            /// <summary>
            /// TransportProtocol
            /// 		
            /// The transport protocol to be used by the VPN session.
            /// 		
            /// Default value: udp
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: tcp | udp
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransportProtocol { get; set; }

            /// <summary>
            /// VpnPort
            /// 		
            /// The port number to assign to the Client VPN endpoint for TCP and UDP traffic.
            /// 	
            /// Valid Values: 443 | 1194
            /// 	
            /// Default Value: 443
            /// 	
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> VpnPort { get; set; }

        }

        public string Type { get; } = "AWS::EC2::ClientVpnEndpoint";

        public ClientVpnEndpointProperties Properties { get; } = new ClientVpnEndpointProperties();

    }
}
