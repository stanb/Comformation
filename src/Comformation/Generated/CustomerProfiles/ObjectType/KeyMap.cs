using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.ObjectType
{
    /// <summary>
    /// AWS::CustomerProfiles::ObjectType KeyMap
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-keymap.html
    /// </summary>
    public class KeyMap
    {

        /// <summary>
        /// Name
        /// Name of the key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ObjectTypeKeyList
        /// A list of ObjectTypeKey.
        /// Required: No
        /// Type: List of ObjectTypeKey
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectTypeKeyList")]
        public List<ObjectTypeKey> ObjectTypeKeyList { get; set; }

    }
}
