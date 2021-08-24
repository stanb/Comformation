using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet GroupIdentifier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-groupidentifier.html
    /// </summary>
    public class GroupIdentifier
    {

        /// <summary>
        /// GroupId
        /// The ID of the security group.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupId")]
        public Union<string, IntrinsicFunction> GroupId { get; set; }

    }
}
