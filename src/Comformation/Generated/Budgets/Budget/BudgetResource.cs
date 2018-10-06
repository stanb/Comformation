using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget
    /// The AWS::Budgets::Budget resource creates, replaces, or deletes budgets for Billing and Cost Management. For
    /// more information, see Managing Your Costs with Budgets in the AWS Billing and Cost Management User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html
    /// </summary>
    public class BudgetResource : ResourceBase
    {
        public class BudgetProperties
        {
            /// <summary>
            /// NotificationsWithSubscribers
            /// The notification that you want associated with the budget. A budget can have up to five
            /// notifications, and each notification can have one SNS subscriber and up to ten email subscribers.
            /// Required: No
            /// Type: List of Billing and Cost Management Budget NotificationWithSubscribers property types
            /// Update requires: Replacement
            /// </summary>
			public List<NotificationWithSubscribers> NotificationsWithSubscribers { get; set; }

            /// <summary>
            /// Budget
            /// The budget for tracking your service usage, costs, and RI utilization. Single accounts and master
            /// and member accounts in an organization can, by default, create budgets.
            /// Required: Yes
            /// Type: Billing and Cost Management Budget BudgetData
            /// Update requires: No interruption
            /// </summary>
			public BudgetData Budget { get; set; }

        }
    
        public string Type { get; } = "AWS::Budgets::Budget";
        
        public BudgetProperties Properties { get; } = new BudgetProperties();

    }
}
