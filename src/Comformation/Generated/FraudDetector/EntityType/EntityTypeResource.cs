using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.EntityType
{
    /// <summary>
    /// AWS::FraudDetector::EntityType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-frauddetector-entitytype.html
    /// </summary>
    public class EntityTypeResource : ResourceBase
    {
        public class EntityTypeProperties
        {
            /// <summary>
            /// Name
            /// The entity type name.
            /// Pattern: ^[0-9a-z_-]+$
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// A key and value pair.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Description
            /// The entity type description.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

        }

        public string Type { get; } = "AWS::FraudDetector::EntityType";

        public EntityTypeProperties Properties { get; } = new EntityTypeProperties();

    }

    public static class EntityTypeAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
    }
}
