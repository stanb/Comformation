using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html
    /// </summary>
    public class BudgetResource : ResourceBase
    {
        public class BudgetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-notificationswithsubscribers
            /// </summary>
			public Union<List<NotificationWithSubscribers>, IntrinsicFunction> NotificationsWithSubscribers { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-budget
            /// </summary>
			public Union<BudgetData, IntrinsicFunction> Budget { get; set; }

        }
    
        public string Type { get; } = "AWS::Budgets::Budget";
        
        public BudgetProperties Properties { get; } = new BudgetProperties();
    }
}
