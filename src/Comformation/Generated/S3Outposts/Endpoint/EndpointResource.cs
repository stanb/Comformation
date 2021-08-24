using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.Endpoint
{
    /// <summary>
    /// AWS::S3Outposts::Endpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-endpoint.html
    /// </summary>
    public class EndpointResource : ResourceBase
    {
        public class EndpointProperties
        {
            /// <summary>
            /// OutpostId
            /// The ID of the Outpost.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OutpostId { get; set; }

            /// <summary>
            /// SecurityGroupId
            /// The ID of the security group to use with the endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SecurityGroupId { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// AccessType
            /// The container for the type of connectivity used to access the Amazon S3 on Outposts endpoint. To use
            /// the Amazon VPC, choose Private. To use the endpoint with an on-premises network, choose
            /// CustomerOwnedIp. If you choose CustomerOwnedIp, you must also provide the customer-owned IP address
            /// pool (CoIP pool).
            /// Note Private is the default access type value.
            /// Required: No
            /// Type: String
            /// Allowed values: CustomerOwnedIp | Private
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AccessType { get; set; }

            /// <summary>
            /// CustomerOwnedIpv4Pool
            /// The ID of the customer-owned IPv4 address pool (CoIP pool) for the endpoint. IP addresses are
            /// allocated from this pool for the endpoint.
            /// Required: No
            /// Type: String
            /// Pattern: ^ipv4pool-coip-([0-9a-f]{17})$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomerOwnedIpv4Pool { get; set; }

        }

        public string Type { get; } = "AWS::S3Outposts::Endpoint";

        public EndpointProperties Properties { get; } = new EndpointProperties();

    }

    public static class EndpointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CidrBlock = new ResourceAttribute<Union<string, IntrinsicFunction>>("CidrBlock");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<List<NetworkInterface>> NetworkInterfaces = new ResourceAttribute<List<NetworkInterface>>("NetworkInterfaces");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
