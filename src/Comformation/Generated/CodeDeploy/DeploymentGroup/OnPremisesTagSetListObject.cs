using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup OnPremisesTagSetListObject
    /// The OnPremisesTagSetListObject property type specifies lists of on-premises instance tag groups. In order for
    /// an instance to be included in the deployment group, it must be identified by all the tag groups in the list.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagsetlistobject.html
    /// </summary>
    public class OnPremisesTagSetListObject
    {

        /// <summary>
        /// OnPremisesTagGroup
        /// Information about groups of on-premises instance tags.
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnPremisesTagGroup")]
        public List<TagFilter> OnPremisesTagGroup { get; set; }

    }
}
