using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// Amazon EC2 EC2Fleet TagSpecification
    /// The TagSpecification property type specifies the tags to apply to a resource when the resource is being
    /// created for an EC2 Fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-tagspecification.html
    /// </summary>
    public class TagSpecification
    {

        /// <summary>
        /// ResourceType
        /// The type of resource to tag. Currently, the resource types that support tagging on creation are
        /// fleet, dedicated-host, instance, snapshot, and volume. To tag a resource after it has been created,
        /// see CreateTags.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

        /// <summary>
        /// Tags
        /// One or more tags. The value parameter is required, but if you don&#39;t want the tag to have a value,
        /// specify the parameter with no value, and we set the value to an empty string.
        /// Required: No
        /// Type: List of Resource Tag property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<TagRequest> Tags { get; set; }

    }
}
