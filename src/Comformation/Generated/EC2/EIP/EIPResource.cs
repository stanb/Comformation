using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EIP
{
    /// <summary>
    /// AWS::EC2::EIP
    /// Specifies an Elastic IP (EIP) address and can, optionally, associate it with an Amazon EC2 instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html
    /// </summary>
    public class EIPResource : ResourceBase
    {
        public class EIPProperties
        {
            /// <summary>
            /// Domain
            /// 		
            /// Set to vpc to allocate the address for use with instances in a VPC.
            /// 		
            /// Default: The address is for use with instances in EC2-Classic.
            /// 	
            /// If you define an Elastic IP address and associate it with a VPC that is defined in the same
            /// template, you 	 must declare a dependency on the VPC-gateway attachment by using the 	 DependsOn
            /// Attribute on this resource.
            /// 		
            /// Required when allocating an address to a VPC
            /// 	
            /// Required: Conditional
            /// Type: String
            /// Allowed Values: standard | vpc
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// InstanceId
            /// 		
            /// The ID of the instance.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// PublicIpv4Pool
            /// 		
            /// The ID of an address pool that you own. Use this parameter to let Amazon EC2 select an address from
            /// the address pool.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PublicIpv4Pool { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EIP";

        public EIPProperties Properties { get; } = new EIPProperties();

    }

	public static class EIPAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AllocationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AllocationId");
	}
}
