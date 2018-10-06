using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS Systems Manager PatchBaseline PatchFilterGroup
    /// The PatchFilterGroup property type specifies a set of patch filters for an AWS Systems Manager patch baseline,
    /// typically used for approval rules for a Systems Manager patch baseline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfiltergroup.html
    /// </summary>
    public class PatchFilterGroup
    {

        /// <summary>
        /// PatchFilters
        /// The set of patch filters that make up the group.
        /// Required: No
        /// Type: List of Systems Manager PatchBaseline PatchFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatchFilters")]
        public List<PatchFilter> PatchFilters { get; set; }

    }
}
