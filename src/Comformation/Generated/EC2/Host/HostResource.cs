using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Host
{
    /// <summary>
    /// AWS::EC2::Host
    /// The AWS::EC2::Host resource allocates a fully dedicated physical server for launching EC2 instances. Because
    /// the host is fully dedicated for your use, it can help you address compliance requirements and reduce costs by
    /// allowing you to use your existing server-bound software licenses. For more information, see Dedicated Hosts in
    /// the Amazon EC2 User Guide for Linux Instances.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-host.html
    /// </summary>
    public class HostResource : ResourceBase
    {
        public class HostProperties
        {
            /// <summary>
            /// AutoPlacement
            /// Indicates if the host accepts EC2 instances with only matching configurations or if instances must
            /// also specify the host ID. Instances that don't specify a host ID can't launch onto a host with
            /// AutoPlacement set to off. By default, AWS CloudFormation sets this property to on. For more
            /// information, see Understanding Instance Placement and Host Affinity in the Amazon EC2 User Guide for
            /// Linux Instances.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-host.html#cfn-ec2-host-autoplacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoPlacement { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone (AZ) in which to launch the dedicated host.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-host.html#cfn-ec2-host-availabilityzone
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type that the dedicated host accepts. Only instances of this type can be launched onto
            /// the host. For more information, see Supported Instance Types in the Amazon EC2 User Guide for Linux
            /// Instances.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-host.html#cfn-ec2-host-instancetype
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::Host";
        
        public HostProperties Properties { get; } = new HostProperties();
    }
}
