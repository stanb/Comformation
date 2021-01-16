using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-analysis.html
    /// </summary>
    public class AnalysisResource : ResourceBase
    {
        public class AnalysisProperties
        {
            /// <summary>
            /// AnalysisId
            /// </summary>
            public Union<string, IntrinsicFunction> AnalysisId { get; set; }

            /// <summary>
            /// AwsAccountId
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// Errors
            /// </summary>
            public List<AnalysisError> Errors { get; set; }

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
            public AnalysisSourceEntity SourceEntity { get; set; }

            /// <summary>
            /// Tags
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ThemeArn
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
