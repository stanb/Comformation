using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup EC2TagSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagset.html
    /// </summary>
    public class EC2TagSet
    {

        /// <summary>
        /// Ec2TagSetList
        /// The Amazon EC2 tags that are already applied to Amazon EC2 instances that you want to include in the
        /// deployment group. CodeDeploy includes all Amazon EC2 instances identified by any of the tags you
        /// specify in this deployment group.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: List of EC2TagSetListObject
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ec2TagSetList")]
        public List<EC2TagSetListObject> Ec2TagSetList { get; set; }

    }
}
