using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsPath
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsPath
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html
    /// </summary>
    public class NetworkInsightsPathResource : ResourceBase
    {
        public class NetworkInsightsPathProperties
        {
            /// <summary>
            /// SourceIp
            /// The IP address of the AWS resource that is the source of the path.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 15
            /// Pattern: ^([0-9]{1,3}. ){3}[0-9]{1,3}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceIp { get; set; }

            /// <summary>
            /// DestinationIp
            /// The IP address of the AWS resource that is the destination of the path.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 15
            /// Pattern: ^([0-9]{1,3}. ){3}[0-9]{1,3}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationIp { get; set; }

            /// <summary>
            /// Source
            /// The AWS resource that is the source of the path.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Source { get; set; }

            /// <summary>
            /// Destination
            /// The AWS resource that is the destination of the path.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Destination { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol.
            /// Required: Yes
            /// Type: String
            /// Allowed values: tcp | udp
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// DestinationPort
            /// The destination port.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 65535
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> DestinationPort { get; set; }

            /// <summary>
            /// Tags
            /// The tags to add to the path.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NetworkInsightsPath";

        public NetworkInsightsPathProperties Properties { get; } = new NetworkInsightsPathProperties();

    }

    public static class NetworkInsightsPathAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkInsightsPathId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkInsightsPathId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkInsightsPathArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkInsightsPathArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedDate");
    }
}
