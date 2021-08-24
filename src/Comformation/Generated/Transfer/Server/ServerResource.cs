using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html
    /// </summary>
    public class ServerResource : ResourceBase
    {
        public class ServerProperties
        {
            /// <summary>
            /// LoggingRole
            /// Specifies the Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that
            /// allows a server to turn on Amazon CloudWatch logging for Amazon S3 or Amazon EFS events. When set,
            /// user activity can be viewed in your CloudWatch logs.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: arn:. *role/. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LoggingRole { get; set; }

            /// <summary>
            /// Protocols
            /// Specifies the file transfer protocol or protocols over which your file transfer protocol client can
            /// connect to your server&#39;s endpoint.
            /// Required: No
            /// Type: List of Protocol
            /// Maximum: 3
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Protocols { get; set; }

            /// <summary>
            /// IdentityProviderDetails
            /// Required when IdentityProviderType is set to AWS_DIRECTORY_SERVICE or API_GATEWAY. Accepts an array
            /// containing all of the information required to use a directory in AWS_DIRECTORY_SERVICE or invoke a
            /// customer-supplied authentication API, including the API Gateway URL. Not required when
            /// IdentityProviderType is set to SERVICE_MANAGED.
            /// Required: No
            /// Type: IdentityProviderDetails
            /// Update requires: No interruption
            /// </summary>
            public IdentityProviderDetails IdentityProviderDetails { get; set; }

            /// <summary>
            /// EndpointType
            /// The type of VPC endpoint that you want your server to connect to. You can choose to connect to the
            /// public internet or a virtual private cloud (VPC) endpoint. With a VPC endpoint, you can restrict
            /// access to your server and resources only within your VPC.
            /// Note It is recommended that you use VPC as the EndpointType. With this endpoint type, you have the
            /// option to directly associate up to three Elastic IPv4 addresses (BYO IP included) with your server&#39;s
            /// endpoint and use VPC security groups to restrict traffic by the client&#39;s public IP address. This is
            /// not possible with EndpointType set to VPC_ENDPOINT.
            /// Required: Conditional
            /// Type: String
            /// Allowed values: PUBLIC | VPC | VPC_ENDPOINT
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointType { get; set; }

            /// <summary>
            /// SecurityPolicyName
            /// Specifies the name of the security policy that is attached to the server.
            /// Required: No
            /// Type: String
            /// Maximum: 100
            /// Pattern: TransferSecurityPolicy-. +
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SecurityPolicyName { get; set; }

            /// <summary>
            /// ProtocolDetails
            /// Protocol settings that are configured for your server.
            /// Note Only valid in the UpdateServer API.
            /// Required: No
            /// Type: ProtocolDetails
            /// Update requires: No interruption
            /// </summary>
            public ProtocolDetails ProtocolDetails { get; set; }

            /// <summary>
            /// Domain
            /// Specifies the domain of the storage system that is used for file transfers.
            /// Required: No
            /// Type: String
            /// Allowed values: EFS | S3
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// EndpointDetails
            /// The virtual private cloud (VPC) endpoint settings that are configured for your server. When you host
            /// your endpoint within your VPC, you can make it accessible only to resources within your VPC, or you
            /// can attach Elastic IPs and make it accessible to clients over the internet. You VPC&#39;s default
            /// security groups are automatically assigned to your endpoint.
            /// Required: No
            /// Type: EndpointDetails
            /// Update requires: No interruption
            /// </summary>
            public EndpointDetails EndpointDetails { get; set; }

            /// <summary>
            /// IdentityProviderType
            /// Specifies the mode of authentication for a server. The default value is SERVICE_MANAGED, which
            /// allows you to store and access user credentials within the AWS Transfer Family service.
            /// Use AWS_DIRECTORY_SERVICE to provide access to Active Directory groups in AWS Managed Active
            /// Directory or Microsoft Active Directory in your on-premises environment or in AWS using AD
            /// Connectors. This option also requires you to provide a Directory ID using the
            /// IdentityProviderDetails parameter.
            /// Use the API_GATEWAY value to integrate with an identity provider of your choosing. The API_GATEWAY
            /// setting requires you to provide an API Gateway endpoint URL to call for authentication using the
            /// IdentityProviderDetails parameter.
            /// Required: No
            /// Type: String
            /// Allowed values: API_GATEWAY | AWS_DIRECTORY_SERVICE | SERVICE_MANAGED
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IdentityProviderType { get; set; }

            /// <summary>
            /// Tags
            /// Key-value pairs that can be used to group and search for servers.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Certificate
            /// The Amazon Resource Name (ARN) of the AWS Certificate Manager (ACM) certificate. Required when
            /// Protocols is set to FTPS.
            /// To request a new public certificate, see Request a public certificate in the AWS Certificate Manager
            /// User Guide.
            /// To import an existing certificate into ACM, see Importing certificates into ACM in the AWS
            /// Certificate Manager User Guide.
            /// To request a private certificate to use FTPS through private IP addresses, see Creating and managing
            /// a Private CA in the AWS Certificate Manager User Guide.
            /// Certificates with the following cryptographic algorithms and key sizes are supported:
            /// 2048-bit RSA (RSA_2048) 4096-bit RSA (RSA_4096) Elliptic Prime Curve 256 bit (EC_prime256v1)
            /// Elliptic Prime Curve 384 bit (EC_secp384r1) Elliptic Prime Curve 521 bit (EC_secp521r1)
            /// Note The certificate must be a valid SSL/TLS X. 509 version 3 certificate with FQDN or IP address
            /// specified and information about the issuer.
            /// Required: No
            /// Type: String
            /// Maximum: 1600
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Certificate { get; set; }

        }

        public string Type { get; } = "AWS::Transfer::Server";

        public ServerProperties Properties { get; } = new ServerProperties();

    }

    public static class ServerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServerId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
