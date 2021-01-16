using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.StackSet
{
    /// <summary>
    /// AWS::CloudFormation::StackSet DeploymentTargets
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-deploymenttargets.html
    /// </summary>
    public class DeploymentTargets
    {

        /// <summary>
        /// Accounts
        /// The names of one or more AWS accounts for which you want to deploy stack set updates.
        /// Pattern: ^[0-9]{12}$
        /// Required: Conditional
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Accounts")]
        public List<Union<string, IntrinsicFunction>> Accounts { get; set; }

        /// <summary>
        /// OrganizationalUnitIds
        /// The organization root ID or organizational unit (OU) IDs to which StackSets deploys.
        /// Pattern: ^(ou-[a-z0-9]{4,32}-[a-z0-9]{8,32}|r-[a-z0-9]{4,32})$
        /// Required: Conditional
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationalUnitIds")]
        public List<Union<string, IntrinsicFunction>> OrganizationalUnitIds { get; set; }

    }
}
