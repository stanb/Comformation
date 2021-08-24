using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.BudgetsAction
{
    /// <summary>
    /// AWS::Budgets::BudgetsAction ScpActionDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-scpactiondefinition.html
    /// </summary>
    public class ScpActionDefinition
    {

        /// <summary>
        /// PolicyId
        /// The policy ID attached.
        /// Required: Yes
        /// Type: String
        /// Minimum: 10
        /// Maximum: 130
        /// Pattern: ^p-[0-9a-zA-Z_]{8,128}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyId")]
        public Union<string, IntrinsicFunction> PolicyId { get; set; }

        /// <summary>
        /// TargetIds
        /// A list of target IDs.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetIds")]
        public List<Union<string, IntrinsicFunction>> TargetIds { get; set; }

    }
}
