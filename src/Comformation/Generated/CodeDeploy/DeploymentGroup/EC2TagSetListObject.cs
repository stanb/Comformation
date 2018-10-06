using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup EC2TagSetListObject
    /// The EC2TagSetListObject property type specifies lists of EC2 tags.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagsetlistobject.html
    /// </summary>
    public class EC2TagSetListObject
    {

        /// <summary>
        /// Ec2TagGroup
        /// The EC2 tags that are already applied to EC2 instances that you want to include in the deployment
        /// group. AWS CodeDeploy includes all EC2 instances identified by any of the tags you specify in this
        /// deployment group.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: List of AWS CodeDeploy DeploymentGroup Ec2TagFilters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ec2TagGroup")]
        public List<EC2TagFilter> Ec2TagGroup { get; set; }

    }
}
