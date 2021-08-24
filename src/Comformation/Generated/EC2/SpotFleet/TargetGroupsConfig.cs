using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet TargetGroupsConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-targetgroupsconfig.html
    /// </summary>
    public class TargetGroupsConfig
    {

        /// <summary>
        /// TargetGroups
        /// One or more target groups.
        /// Required: Yes
        /// Type: List of TargetGroup
        /// Maximum: 5
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TargetGroups")]
        public List<TargetGroup> TargetGroups { get; set; }

    }
}
