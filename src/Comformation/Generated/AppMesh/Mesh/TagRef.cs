using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Mesh
{
    /// <summary>
    /// AWS AppMesh Mesh TagRef
    /// Optional metadata that you apply to a resource to assist with categorization and organization. Each tag
    /// consists of a key and an optional value, both of which you define. Tag keys can have a maximum character
    /// length of 128 characters, and tag values can have a maximum length of 256 characters.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-mesh-tagref.html
    /// </summary>
    public class TagRef
    {

        /// <summary>
        /// Value
        /// The optional part of a key-value pair that make up a tag. A value acts as a descriptor within a tag
        /// category (key).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// One part of a key-value pair that make up a tag. A key is a general label that acts like a category
        /// for more specific tag values.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
