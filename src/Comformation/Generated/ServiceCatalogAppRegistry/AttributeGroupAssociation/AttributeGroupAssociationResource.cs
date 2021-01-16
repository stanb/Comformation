using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalogAppRegistry.AttributeGroupAssociation
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroupassociation.html
    /// </summary>
    public class AttributeGroupAssociationResource : ResourceBase
    {
        public class AttributeGroupAssociationProperties
        {
            /// <summary>
            /// Application
            /// </summary>
            public Union<string, IntrinsicFunction> Application { get; set; }

            /// <summary>
            /// AttributeGroup
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
