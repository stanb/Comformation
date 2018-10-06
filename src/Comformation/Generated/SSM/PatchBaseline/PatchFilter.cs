using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS Systems Manager PatchBaseline PatchFilter
    /// The PatchFilter property type defines a patch filter for an AWS Systems Manager patch baseline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfilter.html
    /// </summary>
    public class PatchFilter
    {

        /// <summary>
        /// Values
        /// The values for the filter key.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Key
        /// The key for the filter. For information about valid keys, see PatchFilter in the AWS Systems Manager
        /// API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
