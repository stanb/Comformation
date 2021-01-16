using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline PatchFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfilter.html
    /// </summary>
    public class PatchFilter
    {

        /// <summary>
        /// Values
        /// The value for the filter key.
        /// For information about valid values for each key based on operating system type, see PatchFilter in
        /// the AWS Systems Manager API Reference.
        /// Required: No
        /// Type: List of String
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Key
        /// The key for the filter.
        /// For information about valid keys, see PatchFilter in the AWS Systems Manager API Reference.
        /// Required: No
        /// Type: String
        /// Allowed values: ADVISORY_ID | ARCH | BUGZILLA_ID | CLASSIFICATION | CVE_ID | EPOCH | MSRC_SEVERITY |
        /// NAME | PATCH_ID | PATCH_SET | PRIORITY | PRODUCT | PRODUCT_FAMILY | RELEASE | REPOSITORY | SECTION |
        /// SECURITY | SEVERITY | VERSION
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
