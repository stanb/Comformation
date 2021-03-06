using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline RuleGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rulegroup.html
    /// </summary>
    public class RuleGroup
    {

        /// <summary>
        /// PatchRules
        /// The rules that make up the rule group.
        /// Required: No
        /// Type: List of Rule
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatchRules")]
        public List<Rule> PatchRules { get; set; }

    }
}
