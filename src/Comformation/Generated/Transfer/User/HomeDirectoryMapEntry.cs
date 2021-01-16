using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.User
{
    /// <summary>
    /// AWS::Transfer::User HomeDirectoryMapEntry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-user-homedirectorymapentry.html
    /// </summary>
    public class HomeDirectoryMapEntry
    {

        /// <summary>
        /// Entry
        /// Represents an entry and a target for HomeDirectoryMappings.
        /// Required: Yes
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Entry")]
        public Union<string, IntrinsicFunction> Entry { get; set; }

        /// <summary>
        /// Target
        /// Represents the map target that is used in a HomeDirectorymapEntry.
        /// Required: Yes
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

    }
}
