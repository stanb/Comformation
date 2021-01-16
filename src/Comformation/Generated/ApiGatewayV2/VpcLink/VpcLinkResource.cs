using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.VpcLink
{
    /// <summary>
    /// AWS::ApiGatewayV2::VpcLink
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-vpclink.html
    /// </summary>
    public class VpcLinkResource : ResourceBase
    {
        public class VpcLinkProperties
        {
            /// <summary>
            /// SubnetIds
            /// A list of subnet IDs to include in the VPC link.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of security group IDs for the VPC link.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// Tags
            /// The collection of tags. Each tag element is associated with a given resource.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the VPC link.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::VpcLink";

        public VpcLinkProperties Properties { get; } = new VpcLinkProperties();

    }
}
