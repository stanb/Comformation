using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightsanalysis.html
    /// </summary>
    public class NetworkInsightsAnalysisResource : ResourceBase
    {
        public class NetworkInsightsAnalysisProperties
        {
            /// <summary>
            /// NetworkInsightsPathId
            /// The ID of the path.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkInsightsPathId { get; set; }

            /// <summary>
            /// FilterInArns
            /// The Amazon Resource Names (ARN) of the resources that the path must traverse.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> FilterInArns { get; set; }

            /// <summary>
            /// Tags
            /// The tags to apply.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NetworkInsightsAnalysis";

        public NetworkInsightsAnalysisProperties Properties { get; } = new NetworkInsightsAnalysisProperties();

    }

    public static class NetworkInsightsAnalysisAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkInsightsAnalysisId = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkInsightsAnalysisId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkInsightsAnalysisArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkInsightsAnalysisArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StartDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("StartDate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusMessage = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusMessage");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> NetworkPathFound = new ResourceAttribute<Union<bool, IntrinsicFunction>>("NetworkPathFound");
        public static readonly ResourceAttribute<List<PathComponent>> ForwardPathComponents = new ResourceAttribute<List<PathComponent>>("ForwardPathComponents");
        public static readonly ResourceAttribute<List<PathComponent>> ReturnPathComponents = new ResourceAttribute<List<PathComponent>>("ReturnPathComponents");
        public static readonly ResourceAttribute<List<Explanation>> Explanations = new ResourceAttribute<List<Explanation>>("Explanations");
        public static readonly ResourceAttribute<List<AlternatePathHint>> AlternatePathHints = new ResourceAttribute<List<AlternatePathHint>>("AlternatePathHints");
    }
}
