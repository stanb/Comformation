using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.FileSystem
{
    /// <summary>
    /// AWS::EFS::FileSystem ElasticFileSystemTag
    /// A tag is a key-value pair attached to a file system. Allowed characters in the Key and Value properties are
    /// letters, white space, and numbers that can be represented in UTF-8, and the following characters: + - = . _ :
    /// /
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-filesystemtags.html
    /// </summary>
    public class ElasticFileSystemTag
    {

        /// <summary>
        /// Key
        /// The tag key (String). The key can&#39;t start with aws:.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value of the tag key.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
