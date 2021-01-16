using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.CapacityProvider
{
    /// <summary>
    /// AWS::ECS::CapacityProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-capacityprovider.html
    /// </summary>
    public class CapacityProviderResource : ResourceBase
    {
        public class CapacityProviderProperties
        {
            /// <summary>
            /// AutoScalingGroupProvider
            /// 		
            /// The Auto Scaling group settings for the capacity provider.
            /// 	
            /// Required: Yes
            /// Type: AutoScalingGroupProvider
            /// Update requires: Replacement
            /// </summary>
            public AutoScalingGroupProvider AutoScalingGroupProvider { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name of the capacity provider.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The metadata that you apply to the capacity provider to help you categorize and 			organize it. Each
            /// tag consists of a key and an optional value, both of which you 			define.
            /// The following basic restrictions apply to tags:
            /// Maximum number of tags per resource - 50 For each resource, each tag key must be unique, and each
            /// tag key can have only one value. Maximum key length - 128 Unicode characters in UTF-8 Maximum value
            /// length - 256 Unicode characters in UTF-8 If your tagging schema is used across multiple services and
            /// resources, remember that other services may have restrictions on allowed characters. Generally
            /// allowed characters are: letters, numbers, and spaces representable in UTF-8, and the following
            /// characters: + - = . _ : / @. Tag keys and values are case-sensitive. Do not use aws:, AWS:, or any
            /// upper or lowercase combination of such as a prefix for either keys or values as it is reserved for
            /// AWS use. You cannot edit or delete tag keys or values with this prefix. Tags with this prefix do not
            /// count against your tags per resource limit.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ECS::CapacityProvider";

        public CapacityProviderProperties Properties { get; } = new CapacityProviderProperties();

    }
}
