using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.BudgetsAction
{
    /// <summary>
    /// AWS::Budgets::BudgetsAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html
    /// </summary>
    public class BudgetsActionResource : ResourceBase
    {
        public class BudgetsActionProperties
        {
            /// <summary>
            /// BudgetName
            /// A string that represents the budget name. &quot;:&quot; and &quot;\&quot; characters aren&#39;t allowed.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BudgetName { get; set; }

            /// <summary>
            /// NotificationType
            /// The type of a notification.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ACTUAL | FORECASTED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NotificationType { get; set; }

            /// <summary>
            /// ActionType
            /// The type of action. This defines the type of tasks that can be carried out by this action. This
            /// field also determines the format for definition.
            /// Required: Yes
            /// Type: String
            /// Allowed values: APPLY_IAM_POLICY | APPLY_SCP_POLICY | RUN_SSM_DOCUMENTS
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ActionType { get; set; }

            /// <summary>
            /// ActionThreshold
            /// The trigger threshold of the action.
            /// Required: Yes
            /// Type: ActionThreshold
            /// Update requires: No interruption
            /// </summary>
            public ActionThreshold ActionThreshold { get; set; }

            /// <summary>
            /// ExecutionRoleArn
            /// The role passed for action execution and reversion. Roles and actions must be in the same account.
            /// Required: Yes
            /// Type: String
            /// Minimum: 32
            /// Maximum: 618
            /// Pattern:
            /// ^arn:(aws|aws-cn|aws-us-gov|us-iso-east-1|us-isob-east-1):iam::\d{12}:role(\u002F[\u0021-\u007F]+\u002F|\u002F)[\w+=,.
            /// @-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// ApprovalModel
            /// This specifies if the action needs manual or automatic approval.
            /// Required: No
            /// Type: String
            /// Allowed values: AUTOMATIC | MANUAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApprovalModel { get; set; }

            /// <summary>
            /// Subscribers
            /// A list of subscribers.
            /// Required: No
            /// Type: List of Subscriber
            /// Update requires: No interruption
            /// </summary>
            public List<Subscriber> Subscribers { get; set; }

            /// <summary>
            /// Definition
            /// Specifies all of the type-specific parameters.
            /// Required: Yes
            /// Type: Definition
            /// Update requires: No interruption
            /// </summary>
            public Definition Definition { get; set; }

        }

        public string Type { get; } = "AWS::Budgets::BudgetsAction";

        public BudgetsActionProperties Properties { get; } = new BudgetsActionProperties();

    }

    public static class BudgetsActionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ActionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ActionId");
    }
}
