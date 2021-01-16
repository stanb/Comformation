using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Dashboard
{
    /// <summary>
    /// AWS::CloudWatch::Dashboard
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html
    /// </summary>
    public class DashboardResource : ResourceBase
    {
        public class DashboardProperties
        {
            /// <summary>
            /// DashboardName
            /// The name of the dashboard. The name must be between 1 and 255 characters. If you do not specify a
            /// name, one will be generated automatically.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardName { get; set; }

            /// <summary>
            /// DashboardBody
            /// 		
            /// The detailed information about the dashboard in JSON format, including the widgets to include and
            /// their location 			on the dashboard. This parameter is required.
            /// 		
            /// For more information about the syntax, 		 	see Dashboard Body Structure and Syntax.
            /// 		 	
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardBody { get; set; }

        }

        public string Type { get; } = "AWS::CloudWatch::Dashboard";

        public DashboardProperties Properties { get; } = new DashboardProperties();

    }
}
