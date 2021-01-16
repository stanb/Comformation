using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html
    /// </summary>
    public class DashboardResource : ResourceBase
    {
        public class DashboardProperties
        {
            /// <summary>
            /// AwsAccountId
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// DashboardId
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardId { get; set; }

            /// <summary>
            /// DashboardPublishOptions
            /// </summary>
            public DashboardPublishOptions DashboardPublishOptions { get; set; }

            /// <summary>
            /// Name
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Parameters
            /// </summary>
            public Parameters Parameters { get; set; }

            /// <summary>
            /// Permissions
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// SourceEntity
            /// </summary>
            public DashboardSourceEntity SourceEntity { get; set; }

            /// <summary>
            /// Tags
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ThemeArn
            /// </summary>
            public Union<string, IntrinsicFunction> ThemeArn { get; set; }

            /// <summary>
            /// VersionDescription
            /// </summary>
            public Union<string, IntrinsicFunction> VersionDescription { get; set; }

        }

        public string Type { get; } = "AWS::QuickSight::Dashboard";

        public DashboardProperties Properties { get; } = new DashboardProperties();

    }

    public static class DashboardAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastPublishedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastPublishedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
        public static readonly ResourceAttribute<DashboardVersion> Version = new ResourceAttribute<DashboardVersion>("Version");
    }
}
