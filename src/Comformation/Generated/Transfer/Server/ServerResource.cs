using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server
    /// Instantiates an autoscaling virtual server based on Secure File Transfer Protocol (SFTP) in AWS. When you make
    /// updates to your server or when you work with users, use the service-generated ServerId property that is
    /// assigned to the newly created server.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html
    /// </summary>
    public class ServerResource : ResourceBase
    {
        public class ServerProperties
        {
            /// <summary>
            /// LoggingRole
            /// A value that allows the service to write your SFTP users&#39; activity to your Amazon CloudWatch logs
            /// for monitoring and auditing purposes.
            /// Required: No
            /// Type: String
            /// Pattern: arn:. *role/. *
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> LoggingRole { get; set; }

            /// <summary>
            /// IdentityProviderDetails
            /// This parameter is required when the IdentityProviderType is set to API_GATEWAY. Accepts an array
            /// containing all of the information required to call a customer-supplied authentication API, including
            /// the API Gateway URL. This property is not required when the IdentityProviderType is set to
            /// SERVICE_MANAGED.
            /// Required: No
            /// Type: IdentityProviderDetails
            /// Update requires: No interruption
            /// </summary>
			public IdentityProviderDetails IdentityProviderDetails { get; set; }

            /// <summary>
            /// EndpointType
            /// The type of VPC endpoint that you want your SFTP server to connect to. If you connect to a VPC
            /// endpoint, your SFTP server isn&#39;t accessible over the public internet.
            /// Required: Conditional
            /// Type: String
            /// Allowed Values: PUBLIC | VPC_ENDPOINT
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointType { get; set; }

            /// <summary>
            /// EndpointDetails
            /// The virtual private cloud (VPC) endpoint settings that you want to configure for your SFTP server.
            /// This parameter is required when you specify a value for the EndpointType parameter.
            /// Required: No
            /// Type: EndpointDetails
            /// Update requires: No interruption
            /// </summary>
			public EndpointDetails EndpointDetails { get; set; }

            /// <summary>
            /// IdentityProviderType
            /// Specifies the mode of authentication for the SFTP server. The default value is SERVICE_MANAGED,
            /// which allows you to store and access SFTP user credentials within the AWS Transfer for SFTP service.
            /// Use the API_GATEWAY value to integrate with an identity provider of your choosing. The API_GATEWAY
            /// setting requires you to provide an API Gateway endpoint URL to call for authentication using the
            /// IdentityProviderDetails parameter.
            /// Required: No
            /// Type: String
            /// Allowed Values: API_GATEWAY | SERVICE_MANAGED
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
