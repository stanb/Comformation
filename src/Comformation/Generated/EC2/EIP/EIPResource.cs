using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EIP
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html
    /// </summary>
    public class EIPResource : ResourceBase
    {
        public class EIPProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-domain
            /// </summary>
			public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::EIP";
        
        public EIPProperties Properties { get; } = new EIPProperties();
    }

	public static class EIPAttributes
	{
        public static readonly ResourceAttribute<string> AllocationId = new ResourceAttribute<string>("AllocationId");
	}
}
