using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.InternetGateway
{
    /// <summary>
    /// AWS::EC2::InternetGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-internetgateway.html
    /// </summary>
    public class InternetGatewayResource : ResourceBase
    {
        public class InternetGatewayProperties
        {
            /// <summary>
            /// Tags
            /// 		
            /// Any tags to assign to the internet gateway.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::InternetGateway";

        public InternetGatewayProperties Properties { get; } = new InternetGatewayProperties();

    }
}
