using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.FileSystem
{
    /// <summary>
    /// Amazon Elastic File System FileSystem FileSystemTags
    /// FileSystemTags is a property of the AWS::EFS::FileSystem resource that associates key-value pairs with a file
    /// system. You can use any of the following Unicode characters for keys and values: letters, digits, whitespace,
    /// _, . , /, =, +, and -.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-filesystem-filesystemtags.html
    /// </summary>
    public class ElasticFileSystemTag
    {

        /// <summary>
        /// Key
        /// The key name of the tag. You can specify a value that is from 1 to 128 Unicode characters in length,
        /// but you cannot use the prefix aws:.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value of the tag key. You can specify a value that is from 0 to 128 Unicode characters in
        /// length.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
