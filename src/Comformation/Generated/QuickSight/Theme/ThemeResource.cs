using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html
    /// </summary>
    public class ThemeResource : ResourceBase
    {
        public class ThemeProperties
        {
            /// <summary>
            /// AwsAccountId
            /// 		
            /// The ID of the AWS account; where you want to store the new theme.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// BaseThemeId
            /// 		
            /// The ID of the theme that a custom theme will inherit from. All themes inherit from one of 			the
            /// starting themes defined by Amazon QuickSight. For a list of the starting themes, use 				ListThemes
            /// or choose Themes from 			within a QuickSight analysis.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: [\w\-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BaseThemeId { get; set; }

            /// <summary>
            /// Configuration
            /// 		
            /// The theme configuration, which contains the theme display properties.
            /// 	
            /// Required: No
            /// Type: ThemeConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ThemeConfiguration Configuration { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// A display name for the theme.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Permissions
            /// 		
            /// A valid grouping of resource permissions to apply to the new theme. 			
            /// 	
            /// Required: No
            /// Type: List of ResourcePermission
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// A map of the key-value pairs for the resource tag or tags that you want to add to the 			resource.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ThemeId
            /// 		
            /// An ID for the theme that you want to create. The theme ID is unique per AWS Region; in 			each AWS
            /// account;.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: [\w\-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ThemeId { get; set; }

            /// <summary>
            /// VersionDescription
            /// 		
            /// A description of the first version of the theme that you&#39;re creating. Every time 				UpdateTheme is
            /// called, a new version is created. Each version of the 			theme has a description of the version in
            /// the VersionDescription 			field.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Update requires: No interruption
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
    }
}
