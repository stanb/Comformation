using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.TagOption
{
    /// <summary>
    /// AWS::ServiceCatalog::TagOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoption.html
    /// </summary>
    public class TagOptionResource : ResourceBase
    {
        public class TagOptionProperties
        {
            /// <summary>
            /// Active
            /// The TagOption active state.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Active { get; set; }

            /// <summary>
            /// Value
            /// The TagOption value.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Value { get; set; }

            /// <summary>
            /// Key
            /// The TagOption key.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Key { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::TagOption";

        public TagOptionProperties Properties { get; } = new TagOptionProperties();

    }
}
