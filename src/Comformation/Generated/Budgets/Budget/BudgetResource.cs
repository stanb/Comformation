using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html
    /// </summary>
    public class BudgetResource : ResourceBase
    {
        public class BudgetProperties
        {
            /// <summary>
            /// NotificationsWithSubscribers
            /// 		
            /// A notification that you want to associate with a budget. A budget can have up to five notifications,
            /// and each notification can have one SNS subscriber and up to 10 email subscribers. If you include
            /// notifications and subscribers in your CreateBudget call, AWS creates the notifications and
            /// subscribers for you.
            /// 	
            /// Required: No
            /// Type: List of NotificationWithSubscribers
            /// Maximum: 10
            /// Update requires: Replacement
            /// </summary>
            public List<NotificationWithSubscribers> NotificationsWithSubscribers { get; set; }

            /// <summary>
            /// Budget
            /// 		
            /// The budget object that you want to create.
            /// 	
            /// Required: Yes
            /// Type: BudgetData
            /// Update requires: No interruption
            /// </summary>
            public BudgetData Budget { get; set; }

        }

        public string Type { get; } = "AWS::Budgets::Budget";

        public BudgetProperties Properties { get; } = new BudgetProperties();

    }
}
