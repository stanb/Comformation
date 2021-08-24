using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dashboard.html
    /// </summary>
    public class DashboardResource : ResourceBase
    {
        public class DashboardProperties
        {
            /// <summary>
            /// AwsAccountId
            /// The ID of the AWS account; where you want to create the dashboard.
            /// Required: Yes
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// DashboardId
            /// The ID for the dashboard, also added to the IAM policy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: [\w\-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DashboardId { get; set; }

            /// <summary>
            /// DashboardPublishOptions
            /// Options for publishing the dashboard when you create it:
            /// AvailabilityStatus for AdHocFilteringOption - This status can be either ENABLED or DISABLED. When
            /// this is set to DISABLED, QuickSight disables the left filter pane on the published dashboard, which
            /// can be used for ad hoc (one-time) filtering. This option is ENABLED by default. AvailabilityStatus
            /// for ExportToCSVOption - This status can be either ENABLED or DISABLED. The visual option to export
            /// data to . CSV format isn&#39;t enabled when this is set to DISABLED. This option is ENABLED by default.
            /// VisibilityState for SheetControlsOption - This visibility state can be either COLLAPSED or EXPANDED.
            /// This option is COLLAPSED by default.
            /// Required: No
            /// Type: DashboardPublishOptions
            /// Update requires: No interruption
            /// </summary>
            public DashboardPublishOptions DashboardPublishOptions { get; set; }

            /// <summary>
            /// Name
            /// The display name of the dashboard.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters for the creation of the dashboard, which you want to use to override the default
            /// settings. A dashboard can have any type of parameters, and some parameters might accept multiple
            /// values.
            /// Required: No
            /// Type: Parameters
            /// Update requires: No interruption
            /// </summary>
            public Parameters Parameters { get; set; }

            /// <summary>
            /// Permissions
            /// A structure that contains the permissions of the dashboard. You can use this structure for granting
            /// permissions by providing a list of IAM action information for each principal ARN.
            /// To specify no permissions, omit the permissions list.
            /// Required: No
            /// Type: List of ResourcePermission
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// SourceEntity
            /// The entity that you are using as a source when you create the dashboard. In SourceEntity, you
            /// specify the type of object you&#39;re using as source. You can only create a dashboard from a template,
            /// so you use a SourceTemplate entity. If you need to create a dashboard from an analysis, first
            /// convert the analysis to a template by using the CreateTheme API operation. For SourceTemplate,
            /// specify the Amazon Resource Name (ARN) of the source template. The SourceTemplateARN can contain any
            /// AWS account and any Amazon QuickSight-supported .
            /// Use the DataSetReferences entity within SourceTemplate to list the replacement datasets for the
            /// placeholders listed in the original. The schema in each dataset must match its placeholder.
            /// Required: No
            /// Type: DashboardSourceEntity
            /// Update requires: No interruption
            /// </summary>
            public DashboardSourceEntity SourceEntity { get; set; }

            /// <summary>
            /// Tags
            /// Contains a map of the key-value pairs for the resource tag or tags assigned to the dashboard.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ThemeArn
            /// The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If you add a
            /// value for this field, it overrides the value that is used in the source entity. The theme ARN must
            /// exist in the same AWS account; where you create the dashboard.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ThemeArn { get; set; }

            /// <summary>
            /// VersionDescription
            /// A description for the first version of the dashboard being created.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Update requires: No interruption
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
    }
}
