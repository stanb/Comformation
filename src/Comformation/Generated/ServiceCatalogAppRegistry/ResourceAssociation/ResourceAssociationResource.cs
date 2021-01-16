using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalogAppRegistry.ResourceAssociation
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html
    /// </summary>
    public class ResourceAssociationResource : ResourceBase
    {
        public class ResourceAssociationProperties
        {
            /// <summary>
            /// Application
            /// </summary>
            public Union<string, IntrinsicFunction> Application { get; set; }

            /// <summary>
            /// Resource
            /// </summary>
            public Union<string, IntrinsicFunction> Resource { get; set; }

            /// <summary>
            /// ResourceType
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceType { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalogAppRegistry::ResourceAssociation";

        public ResourceAssociationProperties Properties { get; } = new ResourceAssociationProperties();

    }

    public static class ResourceAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
