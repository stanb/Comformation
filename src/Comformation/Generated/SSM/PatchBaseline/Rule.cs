using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// ApproveUntilDate
        /// The cutoff date for auto approval of released patches. Any patches released on or before this date
        /// are installed automatically. Not supported on Ubuntu Server.
        /// Enter dates in the format YYYY-MM-DD. For example, 2020-12-31.
        /// Required: No
        /// Type: PatchStringDate
        /// Minimum: 1
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApproveUntilDate")]
        public Union<string, IntrinsicFunction> ApproveUntilDate { get; set; }

        /// <summary>
        /// EnableNonSecurity
        /// For instances identified by the approval rule filters, enables a patch baseline to apply
        /// non-security updates available in the specified repository. The default value is &#39;false&#39;. Applies to
        /// Linux instances only.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableNonSecurity")]
        public Union<bool, IntrinsicFunction> EnableNonSecurity { get; set; }

        /// <summary>
        /// PatchFilterGroup
        /// The patch filter group that defines the criteria for the rule.
        /// Required: No
        /// Type: PatchFilterGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatchFilterGroup")]
        public PatchFilterGroup PatchFilterGroup { get; set; }

        /// <summary>
        /// ApproveAfterDays
        /// The number of days after the release date of each patch matched by the rule that the patch is marked
        /// as approved in the patch baseline. For example, a value of 7 means that patches are approved seven
        /// days after they are released.
        /// You must specify a value for ApproveAfterDays.
        /// Required: Conditional
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApproveAfterDays")]
        public Union<int, IntrinsicFunction> ApproveAfterDays { get; set; }

        /// <summary>
        /// ComplianceLevel
        /// A compliance severity level for all approved patches in a patch baseline. Valid compliance severity
        /// levels include the following: UNSPECIFIED, CRITICAL, HIGH, MEDIUM, LOW, and INFORMATIONAL.
        /// Required: No
        /// Type: String
        /// Allowed values: CRITICAL | HIGH | INFORMATIONAL | LOW | MEDIUM | UNSPECIFIED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComplianceLevel")]
        public Union<string, IntrinsicFunction> ComplianceLevel { get; set; }

    }
}
