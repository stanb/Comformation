using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ResourceGroups.Group
{
    /// <summary>
    /// AWS::ResourceGroups::Group TagFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-tagfilter.html
    /// </summary>
    public class TagFilter
    {

        /// <summary>
        /// Key
        /// A string that defines a tag key. Only resources in the account that are tagged with a specified tag
        /// key are members of the tag-based resource group.
        /// This field is required when the ResourceQuery structure&#39;s Type property is TAG_FILTERS_1_0. You must
        /// specify at least one tag key.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Values
        /// A list of tag values that can be included in the tag-based resource group. This is optional. If you
        /// don&#39;t specify a value or values for a key, then an AWS resource with any value for that key is a
        /// member.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
