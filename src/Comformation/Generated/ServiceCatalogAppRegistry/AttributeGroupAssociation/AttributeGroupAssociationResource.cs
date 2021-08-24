using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalogAppRegistry.AttributeGroupAssociation
{
    /// <summary>
    /// AWS::ServiceCatalogAppRegistry::AttributeGroupAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroupassociation.html
    /// </summary>
    public class AttributeGroupAssociationResource : ResourceBase
    {
        public class AttributeGroupAssociationProperties
        {
            /// <summary>
            /// Application
            /// The name or ID of the application.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Application { get; set; }

            /// <summary>
            /// AttributeGroup
            /// The name or ID of the attribute group that holds the attributes to describe the application.
            /// For more information about using the Ref function, see Ref.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AttributeGroup { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalogAppRegistry::AttributeGroupAssociation";

        public AttributeGroupAssociationProperties Properties { get; } = new AttributeGroupAssociationProperties();

    }

    public static class AttributeGroupAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AttributeGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AttributeGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
