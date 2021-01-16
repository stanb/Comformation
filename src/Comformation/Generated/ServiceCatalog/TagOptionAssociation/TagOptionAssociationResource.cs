using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.TagOptionAssociation
{
    /// <summary>
    /// AWS::ServiceCatalog::TagOptionAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html
    /// </summary>
    public class TagOptionAssociationResource : ResourceBase
    {
        public class TagOptionAssociationProperties
        {
            /// <summary>
            /// TagOptionId
            /// The TagOption identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TagOptionId { get; set; }

            /// <summary>
            /// ResourceId
            /// The resource identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceId { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::TagOptionAssociation";

        public TagOptionAssociationProperties Properties { get; } = new TagOptionAssociationProperties();

    }
}
