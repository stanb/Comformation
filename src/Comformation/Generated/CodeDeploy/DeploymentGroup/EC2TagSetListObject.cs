using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup EC2TagSetListObject
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagsetlistobject.html
    /// </summary>
    public class EC2TagSetListObject
    {

        /// <summary>
        /// Ec2TagGroup
        /// A list that contains other lists of Amazon EC2 instance tag groups. For an instance to be included
        /// in the deployment group, it must be identified by all of the tag groups in the list.
        /// Required: No
        /// Type: List of EC2TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ec2TagGroup")]
        public List<EC2TagFilter> Ec2TagGroup { get; set; }

    }
}
