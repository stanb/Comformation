using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.BudgetsAction
{
    /// <summary>
    /// AWS::Budgets::BudgetsAction Definition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-definition.html
    /// </summary>
    public class Definition
    {

        /// <summary>
        /// IamActionDefinition
        /// The AWS Identity and Access Management (IAM) action definition details.
        /// Required: No
        /// Type: IamActionDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamActionDefinition")]
        public IamActionDefinition IamActionDefinition { get; set; }

        /// <summary>
        /// ScpActionDefinition
        /// The service control policies (SCP) action definition details.
        /// Required: No
        /// Type: ScpActionDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScpActionDefinition")]
        public ScpActionDefinition ScpActionDefinition { get; set; }

        /// <summary>
        /// SsmActionDefinition
        /// The Amazon EC2 Systems Manager (SSM) action definition details.
        /// Required: No
        /// Type: SsmActionDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SsmActionDefinition")]
        public SsmActionDefinition SsmActionDefinition { get; set; }

    }
}
