using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Dashboard
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html
    /// </summary>
    public class DashboardResource : ResourceBase
    {
        public class DashboardProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html#cfn-cloudwatch-dashboard-dashboardname
            /// </summary>
			public Union<string, IntrinsicFunction> DashboardName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html#cfn-cloudwatch-dashboard-dashboardbody
            /// </summary>
			public Union<string, IntrinsicFunction> DashboardBody { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudWatch::Dashboard";
        
        public DashboardProperties Properties { get; } = new DashboardProperties();
    }
}
