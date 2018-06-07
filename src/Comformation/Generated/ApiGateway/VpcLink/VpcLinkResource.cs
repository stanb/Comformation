using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.VpcLink
{
    /// <summary>
    /// AWS::ApiGateway::VpcLink
    /// The AWS::ApiGateway::VpcLink resource specifies an API Gateway VPC link for a AWS::ApiGateway::RestApi to
    /// access resources in an Amazon Virtual Private Cloud (VPC). For more information, see vpclink:create in the
    /// Amazon API Gateway REST API Reference
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-vpclink.html
    /// </summary>
    public class VpcLinkResource : ResourceBase
    {
        public class VpcLinkProperties
        {
            /// <summary>
            /// Description
            /// The description of the VPC link.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-vpclink.html#cfn-apigateway-vpclink-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// TargetArns
            /// The ARNs of network load balancers of the VPC targeted by the VPC link. The network load balancers
            /// must be owned by the same AWS account of the API owner.
            /// Required: Yes
            /// List of Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-vpclink.html#cfn-apigateway-vpclink-targetarns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> TargetArns { get; set; }

            /// <summary>
            /// Name
            /// The name used to label and identify the VPC link.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-vpclink.html#cfn-apigateway-vpclink-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::VpcLink";
        
        public VpcLinkProperties Properties { get; } = new VpcLinkProperties();
    }
}
