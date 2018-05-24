using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.PlacementGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html
    /// </summary>
    public class PlacementGroupResource : ResourceBase
    {
        public class PlacementGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html#cfn-ec2-placementgroup-strategy
            /// </summary>
			public Union<string, IntrinsicFunction> Strategy { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::PlacementGroup";
        
        public PlacementGroupProperties Properties { get; } = new PlacementGroupProperties();
    }
}
