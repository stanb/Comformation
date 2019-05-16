using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet GroupIdentifier
    /// Describes a security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-securitygroups.html
    /// </summary>
    public class GroupIdentifier
    {

        /// <summary>
        /// GroupId
        /// The ID of the security group.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupId")]
        public Union<string, IntrinsicFunction> GroupId { get; set; }

    }
}
