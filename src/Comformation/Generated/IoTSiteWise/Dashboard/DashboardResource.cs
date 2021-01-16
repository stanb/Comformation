using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Dashboard
{
    /// <summary>
    /// AWS::IoTSiteWise::Dashboard
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-dashboard.html
    /// </summary>
    public class DashboardResource : ResourceBase
    {
        public class DashboardProperties
        {
            /// <summary>
            /// ProjectId
            /// The ID of the project in which to create the dashboard.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectId { get; set; }

            /// <summary>
            /// DashboardName
            /// A friendly name for the dashboard.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardName { get; set; }

            /// <summary>
            /// DashboardDescription
            /// A description for the dashboard.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardDescription { get; set; }

            /// <summary>
            /// DashboardDefinition
            /// The dashboard definition specified in a JSON literal. For detailed information, see Creating
            /// dashboards (CLI) in the AWS IoT SiteWise User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardDefinition { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs that contain metadata for the dashboard. For more information, see Tagging
            /// your AWS IoT SiteWise resources in the AWS IoT SiteWise User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTSiteWise::Dashboard";

        public DashboardProperties Properties { get; } = new DashboardProperties();

    }

    public static class DashboardAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DashboardId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DashboardId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DashboardArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DashboardArn");
    }
}
