using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowOutput
{
    /// <summary>
    /// AWS::MediaConnect::FlowOutput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowoutput.html
    /// </summary>
    public class FlowOutputResource : ResourceBase
    {
        public class FlowOutputProperties
        {
            /// <summary>
            /// FlowArn
            /// The Amazon Resource Name (ARN) of the flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FlowArn { get; set; }

            /// <summary>
            /// CidrAllowList
            /// The range of IP addresses that are allowed to initiate output requests to this flow. Format the IP
            /// addresses as a Classless Inter-Domain Routing (CIDR) block; for example, 10. 0. 0. 0/16.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> CidrAllowList { get; set; }

            /// <summary>
            /// Description
            /// A description of the output. This description is not visible outside of the current AWS account even
            /// if the account grants entitlements to other accounts.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Destination
            /// The IP address where you want to send the output.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Destination { get; set; }

            /// <summary>
            /// Encryption
            /// The encryption credentials that you want to use for the output.
            /// Required: No
            /// Type: Encryption
            /// Update requires: No interruption
            /// </summary>
            public Encryption Encryption { get; set; }

            /// <summary>
            /// MaxLatency
            /// The maximum latency in milliseconds for Zixi-based streams.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxLatency { get; set; }

            /// <summary>
            /// Name
            /// The name of the VPC interface.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Port
            /// The port to use when MediaConnect distributes content to the output.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol to use for the output.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// RemoteId
            /// The identifier that is assigned to the Zixi receiver. This parameter applies only to outputs that
            /// use Zixi pull.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RemoteId { get; set; }

            /// <summary>
            /// SmoothingLatency
            /// The smoothing latency in milliseconds for RIST, RTP, and RTP-FEC streams.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> SmoothingLatency { get; set; }

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
            /// VpcInterfaceAttachment
            /// The VPC interface that you want to send your output to.
            /// Required: No
            /// Type: VpcInterfaceAttachment
            /// Update requires: No interruption
            /// </summary>
            public VpcInterfaceAttachment VpcInterfaceAttachment { get; set; }

        }

        public string Type { get; } = "AWS::MediaConnect::FlowOutput";

        public FlowOutputProperties Properties { get; } = new FlowOutputProperties();

    }

    public static class FlowOutputAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OutputArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("OutputArn");
    }
}
