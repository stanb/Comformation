using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TrafficMirrorFilterRule
{
    /// <summary>
    /// AWS::EC2::TrafficMirrorFilterRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html
    /// </summary>
    public class TrafficMirrorFilterRuleResource : ResourceBase
    {
        public class TrafficMirrorFilterRuleProperties
        {
            /// <summary>
            /// DestinationPortRange
            /// The destination port range.
            /// Required: No
            /// Type: TrafficMirrorPortRange
            /// Update requires: No interruption
            /// </summary>
            public TrafficMirrorPortRange DestinationPortRange { get; set; }

            /// <summary>
            /// Description
            /// The description of the Traffic Mirror rule.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SourcePortRange
            /// The source port range.
            /// Required: No
            /// Type: TrafficMirrorPortRange
            /// Update requires: No interruption
            /// </summary>
            public TrafficMirrorPortRange SourcePortRange { get; set; }

            /// <summary>
            /// RuleAction
            /// The action to take on the filtered traffic.
            /// Required: Yes
            /// Type: String
            /// Allowed values: accept | reject
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleAction { get; set; }

            /// <summary>
            /// SourceCidrBlock
            /// The source CIDR block to assign to the Traffic Mirror rule.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SourceCidrBlock { get; set; }

            /// <summary>
            /// RuleNumber
            /// The number of the Traffic Mirror rule. This number must be unique for each Traffic Mirror rule in a
            /// given direction. The rules are processed in ascending order by rule number.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RuleNumber { get; set; }

            /// <summary>
            /// DestinationCidrBlock
            /// The destination CIDR block to assign to the Traffic Mirror rule.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            /// TrafficMirrorFilterId
            /// The ID of the filter that this rule is associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TrafficMirrorFilterId { get; set; }

            /// <summary>
            /// TrafficDirection
            /// The type of traffic.
            /// Required: Yes
            /// Type: String
            /// Allowed values: egress | ingress
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TrafficDirection { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol, for example UDP, to assign to the Traffic Mirror rule.
            /// For information about the protocol value, see Protocol Numbers on the Internet Assigned Numbers
            /// Authority (IANA) website.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Protocol { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TrafficMirrorFilterRule";

        public TrafficMirrorFilterRuleProperties Properties { get; } = new TrafficMirrorFilterRuleProperties();

    }
}
