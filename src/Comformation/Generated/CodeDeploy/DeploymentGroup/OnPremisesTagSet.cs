using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup OnPremisesTagSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagset.html
    /// </summary>
    public class OnPremisesTagSet
    {

        /// <summary>
        /// OnPremisesTagSetList
        /// A list that contains other lists of on-premises instance tag groups. For an instance to be included
        /// in the deployment group, it must be identified by all of the tag groups in the list.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: List of OnPremisesTagSetListObject
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnPremisesTagSetList")]
        public List<OnPremisesTagSetListObject> OnPremisesTagSetList { get; set; }

    }
}
