using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup OnPremisesTagSet
    /// The OnPremisesTagSet property type specifies a list containing other lists of on-premises instance tag groups.
    /// In order for an instance to be included in the deployment group, it must be identified by all the tag groups
    /// in the list.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagset.html
    /// </summary>
    public class OnPremisesTagSet
    {

        /// <summary>
        /// OnPremisesTagSetList
        /// A list containing other lists of on-premises instance tag groups. In order for an instance to be
        /// included in the deployment group, it must be identified by all the tag groups in the list.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: List of AWS CodeDeploy DeploymentGroup OnPremisesTagSetListObject
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnPremisesTagSetList")]
        public List<OnPremisesTagSetListObject> OnPremisesTagSetList { get; set; }

    }
}
