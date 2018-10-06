using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon EC2 SpotFleet TargetGroupsConfig
    /// The TargetGroupsConfig property type describes the target groups to attach to a Spot Fleet. Spot Fleet
    /// registers the running Spot Instances with these target groups.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-targetgroupsconfig.html
    /// </summary>
    public class TargetGroupsConfig
    {

        /// <summary>
        /// TargetGroups
        /// One or more target groups. Duplicates not allowed. For property constraints, see TargetGroupsConfig
        /// in the Amazon EC2 API Reference
        /// Required: Yes
        /// Type: List of Amazon EC2 SpotFleet TargetGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroups")]
        public List<TargetGroup> TargetGroups { get; set; }

    }
}
