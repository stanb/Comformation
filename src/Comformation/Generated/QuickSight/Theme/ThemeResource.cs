using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html
    /// </summary>
    public class ThemeResource : ResourceBase
    {
        public class ThemeProperties
        {
            /// <summary>
            /// AwsAccountId
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// BaseThemeId
            /// </summary>
            public Union<string, IntrinsicFunction> BaseThemeId { get; set; }

            /// <summary>
            /// Configuration
            /// </summary>
            public ThemeConfiguration Configuration { get; set; }

            /// <summary>
            /// Name
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Permissions
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// Tags
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ThemeId
            /// </summary>
            public Union<string, IntrinsicFunction> ThemeId { get; set; }

            /// <summary>
            /// VersionDescription
            /// </summary>
            public Union<string, IntrinsicFunction> VersionDescription { get; set; }

        }

        public string Type { get; } = "AWS::QuickSight::Theme";

        public ThemeProperties Properties { get; } = new ThemeProperties();

    }

    public static class ThemeAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Type = new ResourceAttribute<Union<string, IntrinsicFunction>>("Type");
        public static readonly ResourceAttribute<ThemeVersion> Version = new ResourceAttribute<ThemeVersion>("Version");
    }
}
