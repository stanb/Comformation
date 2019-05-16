using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// AWS::GuardDuty::Filter
    /// The AWS::GuardDuty::Filter resource specifies a new filter defined by the provided findingCriteria.
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
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// Description
            /// The description of the filter.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DetectorId
            /// The ID of the detector to associate the Filter with.
            /// Required: Yes
            /// Type: String
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
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Rank { get; set; }

            /// <summary>
            /// Name
            /// The name of the filter.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::GuardDuty::Filter";

        public FilterProperties Properties { get; } = new FilterProperties();

    }
}
