using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Macie.FindingsFilter
{
    /// <summary>
    /// AWS::Macie::FindingsFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-findingsfilter.html
    /// </summary>
    public class FindingsFilterResource : ResourceBase
    {
        public class FindingsFilterProperties
        {
            /// <summary>
            /// Name
            /// A custom name for the filter. The name must contain at least 3 characters and can contain as many as
            /// 64 characters.
            /// We strongly recommend that you avoid including any sensitive data in the name of a filter. Other
            /// users might be able to see the filter&#39;s name, depending on the actions that they&#39;re allowed to
            /// perform in Amazon Macie.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// A custom description of the filter. The description can contain as many as 512 characters.
            /// We strongly recommend that you avoid including any sensitive data in the description of a filter.
            /// Other users might be able to see the filter&#39;s description, depending on the actions that they&#39;re
            /// allowed to perform in Amazon Macie.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FindingCriteria
            /// The criteria to use to filter findings.
            /// Required: Yes
            /// Type: FindingCriteria
            /// Update requires: No interruption
            /// </summary>
            public FindingCriteria FindingCriteria { get; set; }

            /// <summary>
            /// Action
            /// The action to perform on findings that meet the filter criteria (FindingCriteria). Valid values are:
            /// ARCHIVE - Suppress (automatically archive) the findings. NOOP - Don&#39;t perform any action on the
            /// findings.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// Position
            /// The position of the filter in the list of saved filters on the Amazon Macie console. This value also
            /// determines the order in which the filter is applied to findings, relative to other filters that are
            /// also applied to the findings.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Position { get; set; }

        }

        public string Type { get; } = "AWS::Macie::FindingsFilter";

        public FindingsFilterProperties Properties { get; } = new FindingsFilterProperties();

    }

    public static class FindingsFilterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<List<FindingsFilterListItem>> FindingsFilterListItems = new ResourceAttribute<List<FindingsFilterListItem>>("FindingsFilterListItems");
    }
}
