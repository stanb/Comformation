using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint
    /// Specifies a Client VPN endpoint. A Client VPN endpoint is the resource you create and configure to 			enable
    /// and manage client VPN sessions. It is the destination endpoint at which all client VPN sessions 			are
    /// terminated.
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
            /// TransportProtocol
            /// 		
            /// The transport protocol to be used by the VPN session.
            /// 		
            /// Default value: udp
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed Values: tcp | udp
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TransportProtocol { get; set; }

        }

        public string Type { get; } = "AWS::EC2::ClientVpnEndpoint";

        public ClientVpnEndpointProperties Properties { get; } = new ClientVpnEndpointProperties();

    }
}
