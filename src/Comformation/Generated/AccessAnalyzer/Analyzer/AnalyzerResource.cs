using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AccessAnalyzer.Analyzer
{
    /// <summary>
    /// AWS::AccessAnalyzer::Analyzer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html
    /// </summary>
    public class AnalyzerResource : ResourceBase
    {
        public class AnalyzerProperties
        {
            /// <summary>
            /// AnalyzerName
            /// The name of the analyzer.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AnalyzerName { get; set; }

            /// <summary>
            /// ArchiveRules
            /// Specifies the archive rules to add for the analyzer.
            /// Required: No
            /// Type: List of ArchiveRule
            /// Update requires: No interruption
            /// </summary>
            public List<ArchiveRule> ArchiveRules { get; set; }

            /// <summary>
            /// Tags
            /// The tags to apply to the analyzer.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type represents the zone of trust for the analyzer.
            /// Allowed Values: ACCOUNT | ORGANIZATION
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::AccessAnalyzer::Analyzer";

        public AnalyzerProperties Properties { get; } = new AnalyzerProperties();

    }

    public static class AnalyzerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
