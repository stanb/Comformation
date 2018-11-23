using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup TagProperty
    /// The TagProperty property type adds tags to all associated instances in an Amazon EC2 Auto Scaling group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-tags.html
    /// </summary>
    public class TagProperty
    {

        /// <summary>
        /// Key
        /// The key name of the tag.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// PropagateAtLaunch
        /// Set to true if you want AWS CloudFormation to copy the tag to EC2 instances that are launched as
        /// part of the Auto Scaling group. Set to false if you want the tag attached only to the Auto Scaling
        /// group and not copied to any instances launched as part of the Auto Scaling group.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("PropagateAtLaunch")]
        public Union<bool, IntrinsicFunction> PropagateAtLaunch { get; set; }

        /// <summary>
        /// Value
        /// The value for the tag.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
