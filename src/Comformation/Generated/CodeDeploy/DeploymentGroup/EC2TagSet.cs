using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup EC2TagSet
    /// The EC2TagSet property type specifies information about groups of tags applied to EC2 instances. The
    /// deployment group will include only EC2 instances identified by all the tag groups. Cannot be used in the same
    /// template as EC2TagFilters.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagset.html
    /// </summary>
    public class EC2TagSet
    {

        /// <summary>
        /// Ec2TagSetList
        /// A list containing other lists of EC2 instance tag groups. In order for an instance to be included in
        /// the deployment group, it must be identified by all the tag groups in the list.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: List of AWS CodeDeploy DeploymentGroup EC2TagSetListObject
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ec2TagSetList")]
        public List<EC2TagSetListObject> Ec2TagSetList { get; set; }

    }
}
