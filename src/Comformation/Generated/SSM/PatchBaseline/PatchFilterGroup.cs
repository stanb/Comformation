using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline PatchFilterGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfiltergroup.html
    /// </summary>
    public class PatchFilterGroup
    {

        /// <summary>
        /// PatchFilters
        /// The set of patch filters that make up the group.
        /// Required: No
        /// Type: List of PatchFilter
        /// Maximum: 4
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatchFilters")]
        public List<PatchFilter> PatchFilters { get; set; }

    }
}
