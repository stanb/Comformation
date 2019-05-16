using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Host
{
    /// <summary>
    /// AWS::EC2::Host
    /// Allocates a fully dedicated physical server 			for launching EC2 instances. Because the host is fully
    /// dedicated for your use, it can 			help you address compliance requirements and reduce costs by allowing you to
    /// use your 			existing server-bound software licenses. For more information, see 				Dedicated Hosts in the
    /// Amazon EC2 User Guide for Linux 					Instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-host.html
    /// </summary>
    public class HostResource : ResourceBase
    {
        public class HostProperties
        {
            /// <summary>
            /// AutoPlacement
            /// 	
            /// Indicates whether the host accepts any untargeted instance launches that 		match its instance type
            /// configuration, or if it only accepts Host tenancy 		instance launches that specify its unique host
            /// ID. For more information, 		see 	Understanding Instance Placement and Host Affinity in the 	Amazon
            /// EC2 User Guide for Linux Instances.
            /// Default: on
            /// Required: No
            /// Type: String
            /// Allowed Values: off | on
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AutoPlacement { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone in which to allocate the Dedicated Host.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// InstanceType
            /// Specifies the instance type for which to configure your Dedicated Hosts. When you 			specify the
            /// instance type, that is the only instance type that you can launch onto that 			host.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

        }

        public string Type { get; } = "AWS::EC2::Host";

        public HostProperties Properties { get; } = new HostProperties();

    }
}
