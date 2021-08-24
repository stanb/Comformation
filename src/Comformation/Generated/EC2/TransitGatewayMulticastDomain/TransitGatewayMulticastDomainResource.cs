using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayMulticastDomain
{
    /// <summary>
    /// AWS::EC2::TransitGatewayMulticastDomain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomain.html
    /// </summary>
    public class TransitGatewayMulticastDomainResource : ResourceBase
    {
        public class TransitGatewayMulticastDomainProperties
        {
            /// <summary>
            /// TransitGatewayId
            /// The ID of the transit gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayId { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the transit gateway multicast domain.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Options
            /// The options for the transit gateway multicast domain.
            /// autoAcceptSharedAssociations (enable | disable) igmpv2Support (enable | disable)
            /// staticSourcesSupport (enable | disable)
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Options { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayMulticastDomain";

        public TransitGatewayMulticastDomainProperties Properties { get; } = new TransitGatewayMulticastDomainProperties();

    }

    public static class TransitGatewayMulticastDomainAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TransitGatewayMulticastDomainId = new ResourceAttribute<Union<string, IntrinsicFunction>>("TransitGatewayMulticastDomainId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TransitGatewayMulticastDomainArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TransitGatewayMulticastDomainArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
