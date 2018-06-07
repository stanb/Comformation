using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.InternetGateway
{
    /// <summary>
    /// AWS::EC2::InternetGateway
    /// Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach it to
    /// a VPC.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-internetgateway.html
    /// </summary>
    public class InternetGatewayResource : ResourceBase
    {
        public class InternetGatewayProperties
        {
            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this resource.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-internetgateway.html#cfn-ec2-internetgateway-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::InternetGateway";
        
        public InternetGatewayProperties Properties { get; } = new InternetGatewayProperties();
    }
}
