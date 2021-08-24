using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayMulticastDomainAssociation
{
    /// <summary>
    /// AWS::EC2::TransitGatewayMulticastDomainAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomainassociation.html
    /// </summary>
    public class TransitGatewayMulticastDomainAssociationResource : ResourceBase
    {
        public class TransitGatewayMulticastDomainAssociationProperties
        {
            /// <summary>
            /// TransitGatewayMulticastDomainId
            /// The ID of the transit gateway multicast domain.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayMulticastDomainId { get; set; }

            /// <summary>
            /// TransitGatewayAttachmentId
            /// The ID of the transit gateway attachment.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayAttachmentId { get; set; }

            /// <summary>
            /// SubnetId
            /// The IDs of the subnets to associate with the transit gateway multicast domain.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGatewayMulticastDomainAssociation";

        public TransitGatewayMulticastDomainAssociationProperties Properties { get; } = new TransitGatewayMulticastDomainAssociationProperties();

    }

    public static class TransitGatewayMulticastDomainAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceType = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceType");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
    }
}
