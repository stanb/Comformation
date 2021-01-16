using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Host
{
    /// <summary>
    /// AWS::EC2::Host
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
            /// ID. For more information, 		see 	Understanding auto-placement and affinity in the Amazon EC2 User
            /// Guide.
            /// Default: on
            /// Required: No
            /// Type: String
            /// Allowed values: off | on
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
            /// HostRecovery
            /// 		
            /// Indicates whether to enable or disable host recovery for the Dedicated Host. 			Host recovery is
            /// disabled by default. For more information, see 			 			Host recovery in the Amazon EC2 User Guide.
            /// 		
            /// Default: off
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: off | on
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HostRecovery { get; set; }

            /// <summary>
            /// InstanceType
            /// Specifies the instance type to be supported by the Dedicated Hosts. If you 		specify an instance
            /// type, the Dedicated Hosts support instances of the 		specified instance type only.
            /// 	
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
