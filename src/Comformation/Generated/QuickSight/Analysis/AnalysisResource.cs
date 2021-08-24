using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// AWS::QuickSight::Analysis
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html
    /// </summary>
    public class AnalysisResource : ResourceBase
    {
        public class AnalysisProperties
        {
            /// <summary>
            /// AnalysisId
            /// The ID for the analysis that you&#39;re creating. This ID displays in the URL of the analysis.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: [\w\-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AnalysisId { get; set; }

            /// <summary>
            /// AwsAccountId
            /// The ID of the AWS account; where you are creating an analysis.
            /// Required: Yes
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// Errors
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of AnalysisError
            /// Update requires: No interruption
            /// </summary>
            public List<AnalysisError> Errors { get; set; }

            /// <summary>
            /// Name
            /// A descriptive name for the analysis that you&#39;re creating. This name displays for the analysis in the
            /// QuickSight console.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Parameters
            /// The parameter names and override values that you want to use. An analysis can have any parameter
            /// type, and some parameters might accept multiple values.
            /// Required: No
            /// Type: Parameters
            /// Update requires: No interruption
            /// </summary>
            public Parameters Parameters { get; set; }

            /// <summary>
            /// Permissions
            /// A structure that describes the principals and the resource-level permissions on an analysis. You can
            /// use the Permissions structure to grant permissions by providing a list of AWS Identity and Access
            /// Management (IAM) action information for each principal listed by Amazon Resource Name (ARN).
            /// To specify no permissions, omit Permissions.
            /// Required: No
            /// Type: List of ResourcePermission
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// SourceEntity
            /// A source entity to use for the analysis that you&#39;re creating. This metadata structure contains
            /// details that describe a source template and one or more datasets.
            /// Required: No
            /// Type: AnalysisSourceEntity
            /// Update requires: No interruption
            /// </summary>
            public AnalysisSourceEntity SourceEntity { get; set; }

            /// <summary>
            /// Tags
            /// Contains a map of the key-value pairs for the resource tag or tags assigned to the analysis.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ThemeArn
            /// The ARN for the theme to apply to the analysis that you&#39;re creating. To see the theme in the
            /// QuickSight console, make sure that you have access to it.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ThemeArn { get; set; }

        }

        public string Type { get; } = "AWS::QuickSight::Analysis";

        public AnalysisProperties Properties { get; } = new AnalysisProperties();

    }

    public static class AnalysisAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> DataSetArns = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("DataSetArns");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
        public static readonly ResourceAttribute<List<Sheet>> Sheets = new ResourceAttribute<List<Sheet>>("Sheets");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
