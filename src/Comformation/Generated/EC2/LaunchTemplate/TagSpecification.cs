using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate TagSpecification
    /// The TagSpecification property type specifies the tags specification for an Amazon EC2 launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-tagspecification.html
    /// </summary>
    public class TagSpecification
    {

        /// <summary>
        /// ResourceType
        /// The type of resource to tag. Currently, the resource types that support tagging on creation are
        /// instance and volume.
        /// For a list of valid values, see LaunchTemplateTagSpecificationRequest in the Amazon EC2 API
        /// Reference
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

        /// <summary>
        /// Tags
        /// The tags to apply to the resource.
        /// Required: No
        /// Type: List of AWS CloudFormation Resource Tags
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

    }
}
