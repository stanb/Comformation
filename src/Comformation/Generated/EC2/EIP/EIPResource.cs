using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EIP
{
    /// <summary>
    /// AWS::EC2::EIP
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html
    /// </summary>
    public class EIPResource : ResourceBase
    {
        public class EIPProperties
        {
            /// <summary>
            /// Domain
            /// 		
            /// Indicates whether the Elastic IP address is for use with instances in a VPC or instance in
            /// EC2-Classic.
            /// 		
            /// Default: If the Region supports EC2-Classic, the default is standard. 		 Otherwise, the default is
            /// vpc.
            /// 	
            /// Use when allocating an address for use with a VPC if the Region supports EC2-Classic.
            /// 	
            /// If you define an Elastic IP address and associate it with a VPC that is defined in the same
            /// template, you 	 must declare a dependency on the VPC-gateway attachment by using the 	 DependsOn
            /// Attribute on this resource.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: standard | vpc
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// InstanceId
            /// 		
            /// The ID of the instance.
            /// 	
            /// Important Updates to the InstanceId property may require some interruptions. Updates on an EIP
            /// reassociates the address on its associated resource.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// PublicIpv4Pool
            /// 		
            /// The ID of an address pool that you own. Use this parameter to let Amazon EC2 select an address from
            /// the address pool.
            /// 	
            /// Important Updates to the PublicIpv4Pool property may require some interruptions. Updates on an EIP
            /// reassociates the address on its associated resource.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> PublicIpv4Pool { get; set; }

            /// <summary>
            /// Tags
            /// Any tags assigned to the Elastic IP address.
            /// Important Updates to the Tags property may require some interruptions. Updates on an EIP
            /// reassociates the address on its associated resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EIP";

        public EIPProperties Properties { get; } = new EIPProperties();

    }

    public static class EIPAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AllocationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AllocationId");
    }
}
