using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.VpcLink
{
    /// <summary>
    /// AWS::ApiGateway::VpcLink
    /// The AWS::ApiGateway::VpcLink resource creates an API Gateway VPC link for a REST API to access resources in an
    /// Amazon Virtual Private Cloud (VPC). For more information, see vpclink:create in the Amazon API Gateway REST
    /// API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-vpclink.html
    /// </summary>
    public class VpcLinkResource : ResourceBase
    {
        public class VpcLinkProperties
        {
            /// <summary>
            /// Description
            /// A description of the VPC link.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// TargetArns
            /// The ARNs of network load balancers of the VPC targeted by the VPC link. The network load balancers
            /// must be owned by the same AWS account of the API owner.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> TargetArns { get; set; }

            /// <summary>
            /// Name
            /// A name for the VPC link.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::VpcLink";

        public VpcLinkProperties Properties { get; } = new VpcLinkProperties();

    }
}
