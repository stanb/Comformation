using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowSource
{
    /// <summary>
    /// AWS::MediaConnect::FlowSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html
    /// </summary>
    public class FlowSourceResource : ResourceBase
    {
        public class FlowSourceProperties
        {
            /// <summary>
            /// FlowArn
            /// The Amazon Resource Name (ARN) of the flow.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FlowArn { get; set; }

            /// <summary>
            /// Decryption
            /// The type of encryption that is used on the content ingested from the source.
            /// Required: No
            /// Type: Encryption
            /// Update requires: No interruption
            /// </summary>
            public Encryption Decryption { get; set; }

            /// <summary>
            /// Description
            /// A description of the source. This description is not visible outside of the current AWS account.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EntitlementArn
            /// The ARN of the entitlement that allows you to subscribe to the flow. The entitlement is set by the
            /// content originator, and the ARN is generated as part of the originator&#39;s flow.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EntitlementArn { get; set; }

            /// <summary>
            /// IngestPort
            /// The port that the flow listens on for incoming content. If the protocol of the source is Zixi, the
            /// port must be set to 2088.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> IngestPort { get; set; }

            /// <summary>
            /// MaxBitrate
            /// The maximum bitrate for RIST, RTP, and RTP-FEC streams.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxBitrate { get; set; }

            /// <summary>
            /// MaxLatency
            /// The maximum latency in milliseconds for RIST and Zixi-based streams.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxLatency { get; set; }

            /// <summary>
            /// Name
            /// The name of the source.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol that the source uses to deliver the content to MediaConnect.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// StreamId
            /// The stream ID that you want to use for the transport. This parameter applies only to Zixi-based
            /// streams.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StreamId { get; set; }

            /// <summary>
            /// VpcInterfaceName
            /// The name of the VPC interface that you want to send your output to.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VpcInterfaceName { get; set; }

            /// <summary>
            /// WhitelistCidr
            /// The range of IP addresses that are allowed to contribute content to your source. Format the IP
            /// addresses as a Classless Inter-Domain Routing (CIDR) block; for example, 10. 0. 0. 0/16.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> WhitelistCidr { get; set; }

        }

        public string Type { get; } = "AWS::MediaConnect::FlowSource";

        public FlowSourceProperties Properties { get; } = new FlowSourceProperties();

    }

    public static class FlowSourceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SourceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SourceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IngestIp = new ResourceAttribute<Union<string, IntrinsicFunction>>("IngestIp");
    }
}
