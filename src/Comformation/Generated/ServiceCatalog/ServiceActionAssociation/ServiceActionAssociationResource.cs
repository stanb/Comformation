using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.ServiceActionAssociation
{
    /// <summary>
    /// AWS::ServiceCatalog::ServiceActionAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-serviceactionassociation.html
    /// </summary>
    public class ServiceActionAssociationResource : ResourceBase
    {
        public class ServiceActionAssociationProperties
        {
            /// <summary>
            /// ProductId
            /// The product identifier. For example, prod-abcdzk7xy33qa.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProductId { get; set; }

            /// <summary>
            /// ProvisioningArtifactId
            /// The identifier of the provisioning artifact. For example, pa-4abcdjnxjj6ne.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProvisioningArtifactId { get; set; }

            /// <summary>
            /// ServiceActionId
            /// The self-service action identifier. For example, act-fs7abcd89wxyz.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceActionId { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::ServiceActionAssociation";

        public ServiceActionAssociationProperties Properties { get; } = new ServiceActionAssociationProperties();

    }
}
