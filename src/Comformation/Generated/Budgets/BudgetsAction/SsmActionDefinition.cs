using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.BudgetsAction
{
    /// <summary>
    /// AWS::Budgets::BudgetsAction SsmActionDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-ssmactiondefinition.html
    /// </summary>
    public class SsmActionDefinition
    {

        /// <summary>
        /// Subtype
        /// The action subType.
        /// Required: Yes
        /// Type: String
        /// Allowed values: STOP_EC2_INSTANCES | STOP_RDS_INSTANCES
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subtype")]
        public Union<string, IntrinsicFunction> Subtype { get; set; }

        /// <summary>
        /// Region
        /// The Region to run the (SSM) document.
        /// Required: Yes
        /// Type: String
        /// Minimum: 9
        /// Maximum: 20
        /// Pattern: ^\w{2}-\w+(-\w+)?-\d$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// InstanceIds
        /// The EC2 and RDS instance IDs.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceIds")]
        public List<Union<string, IntrinsicFunction>> InstanceIds { get; set; }

    }
}
