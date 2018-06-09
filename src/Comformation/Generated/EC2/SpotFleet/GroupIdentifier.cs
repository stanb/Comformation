using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet SecurityGroups
    /// SecurityGroups is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications property that
    /// specifies a security group to associate with the instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-securitygroups.html
    /// </summary>
    public class GroupIdentifier
    {

        /// <summary>
        /// GroupId
        /// The ID of a security group.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("GroupId")]
        public Union<string, IntrinsicFunction> GroupId { get; set; }

    }
}
