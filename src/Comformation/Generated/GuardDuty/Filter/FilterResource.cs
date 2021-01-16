using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// AWS::GuardDuty::Filter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html
    /// </summary>
    public class FilterResource : ResourceBase
    {
        public class FilterProperties
        {
            /// <summary>
            /// Action
            /// Specifies the action that is to be applied to the findings that match the filter.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ARCHIVE | NOOP
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// Description
            /// The description of the filter.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 512
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DetectorId
            /// The ID of the detector belonging to the GuardDuty account that you want to create a filter for.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// FindingCriteria
            /// Represents the criteria to be used in the filter for querying findings.
            /// Required: Yes
            /// Type: FindingCriteria
            /// Update requires: No interruption
            /// </summary>
            public FindingCriteria FindingCriteria { get; set; }

            /// <summary>
            /// Rank
            /// Specifies the position of the filter in the list of current filters. Also specifies the order in
            /// which this filter is applied to the findings.
            /// Important By default filters may not be created in the same order as they are ranked. To ensure
            /// filters are created in the correct order you can use the optional DependsOn attribute with the
            /// following syntax: &quot;DependsOn&quot;:[ &quot;ObjectName&quot; ]. You can find more information on using this
            /// attribute here.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Rank { get; set; }

            /// <summary>
            /// Name
            /// The name of the filter. Minimum length of 3. Maximum length of 64. Valid characters include
            /// alphanumeric characters, dot (. ), underscore (_), and dash (-). Spaces are not allowed.
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::GuardDuty::Filter";

        public FilterProperties Properties { get; } = new FilterProperties();

    }
}
