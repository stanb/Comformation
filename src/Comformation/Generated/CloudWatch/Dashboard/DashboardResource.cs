using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Dashboard
{
    /// <summary>
    /// AWS::CloudWatch::Dashboard
    /// The AWS::CloudWatch::Dashboard resource creates an Amazon CloudWatch dashboard. A dashboard is a customizable
    /// home page in the CloudWatch console that you can use to monitor your AWS resources in a single view. Each
    /// metric, graph, alarm, or text block on a dashboard is called a widget.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-dashboard.html
    /// </summary>
    public class DashboardResource : ResourceBase
    {
        public class DashboardProperties
        {
            /// <summary>
            /// DashboardName
            /// A name for the dashboard. The name must be between 1 and 255 characters. If you do not specify a
            /// name, one will be generated automatically.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-dashboard.html#cfn-cloudwatch-dashboard-name
            /// </summary>
			public Union<string, IntrinsicFunction> DashboardName { get; set; }

            /// <summary>
            /// DashboardBody
            /// A JSON string that defines the widgets contained in the dashboard and their location. For
            /// information about how to format this string, see Dashboard Body Structure and Syntax.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-dashboard.html#cfn-cloudwatch-dashboard-body
            /// </summary>
			public Union<string, IntrinsicFunction> DashboardBody { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudWatch::Dashboard";
        
        public DashboardProperties Properties { get; } = new DashboardProperties();
    }
}
