using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet
    /// The AWS::EC2::SpotFleet resource creates a request for a collection of Spot instances. The Spot fleet attempts
    /// to launch the number of Spot instances to meet the target capacity that you specified. For more information,
    /// see Spot Instances in the Amazon EC2 User Guide for Linux Instances.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html
    /// </summary>
    public class SpotFleetResource : ResourceBase
    {
        public class SpotFleetProperties
        {
            /// <summary>
            /// SpotFleetRequestConfigData
            /// The configuration for a Spot fleet request.
            /// Required: Yes
            /// Type: Amazon EC2 SpotFleet SpotFleetRequestConfigData
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata
            /// </summary>
			public Union<SpotFleetRequestConfigData, IntrinsicFunction> SpotFleetRequestConfigData { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SpotFleet";
        
        public SpotFleetProperties Properties { get; } = new SpotFleetProperties();
    }
}
