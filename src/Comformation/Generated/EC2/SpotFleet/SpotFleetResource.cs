using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html
    /// </summary>
    public class SpotFleetResource : ResourceBase
    {
        public class SpotFleetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata
            /// </summary>
			public Union<SpotFleetRequestConfigData, IntrinsicFunction> SpotFleetRequestConfigData { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SpotFleet";
        
        public SpotFleetProperties Properties { get; } = new SpotFleetProperties();
    }
}
