using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// AWS::GuardDuty::Filter
    /// You can use the AWS::GuardDuty::Filter resource to create a GuardDuty filter using the specified finding
    /// criteria.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html
    /// </summary>
    public class FilterResource : ResourceBase
    {
        public class FilterProperties
        {
            /// <summary>
            /// Action
            /// Specifies the action that is to be applied to the findings that match the filter. Valid values are:
            /// NOOP | ARCHIVE
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-action
            /// </summary>
			public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// Description
            /// The description of the filter.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DetectorId
            /// The ID of the detector that specifies the GuardDuty service whose findings you want to filter.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-detectorid
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// FindingCriteria
            /// Represents the criteria to be used in the filter for querying findings.
            /// Required: Yes
            /// Type: GuardDuty Filter FindingCriteria
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-findingcriteria
            /// </summary>
			public Union<FindingCriteria, IntrinsicFunction> FindingCriteria { get; set; }

            /// <summary>
            /// Rank
            /// Specifies the position of the filter in the list of current filters. Also specifies the order in
            /// which this filter is applied to the findings.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-rank
            /// </summary>
			public Union<int, IntrinsicFunction> Rank { get; set; }

            /// <summary>
            /// Name
            /// The name of the filter.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::Filter";
        
        public FilterProperties Properties { get; } = new FilterProperties();
    }
}
