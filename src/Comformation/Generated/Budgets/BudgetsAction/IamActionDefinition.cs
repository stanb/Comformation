using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.BudgetsAction
{
    /// <summary>
    /// AWS::Budgets::BudgetsAction IamActionDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-iamactiondefinition.html
    /// </summary>
    public class IamActionDefinition
    {

        /// <summary>
        /// PolicyArn
        /// The Amazon Resource Name (ARN) of the policy to be attached.
        /// Required: Yes
        /// Type: String
        /// Minimum: 25
        /// Maximum: 684
        /// Pattern:
        /// ^arn:(aws|aws-cn|aws-us-gov|us-iso-east-1|us-isob-east-1):iam::(\d{12}|aws):policy(\u002F[\u0021-\u007F]+\u002F|\u002F)[\w+=,.
        /// @-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyArn")]
        public Union<string, IntrinsicFunction> PolicyArn { get; set; }

        /// <summary>
        /// Roles
        /// A list of roles to be attached. There must be at least one role.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Roles")]
        public List<Union<string, IntrinsicFunction>> Roles { get; set; }

        /// <summary>
        /// Groups
        /// A list of groups to be attached. There must be at least one group.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Groups")]
        public List<Union<string, IntrinsicFunction>> Groups { get; set; }

        /// <summary>
        /// Users
        /// A list of users to be attached. There must be at least one user.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Users")]
        public List<Union<string, IntrinsicFunction>> Users { get; set; }

    }
}
