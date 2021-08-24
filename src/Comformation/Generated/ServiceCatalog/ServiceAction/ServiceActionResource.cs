using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.ServiceAction
{
    /// <summary>
    /// AWS::ServiceCatalog::ServiceAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-serviceaction.html
    /// </summary>
    public class ServiceActionResource : ResourceBase
    {
        public class ServiceActionProperties
        {
            /// <summary>
            /// AcceptLanguage
            /// The language code.
            /// en - English (default) jp - Japanese zh - Chinese
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AcceptLanguage { get; set; }

            /// <summary>
            /// Name
            /// The self-service action name.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[a-zA-Z0-9_\-. ]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DefinitionType
            /// The self-service action definition type. For example, SSM_AUTOMATION.
            /// Required: Yes
            /// Type: String
            /// Allowed values: SSM_AUTOMATION
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefinitionType { get; set; }

            /// <summary>
            /// Definition
            /// A map that defines the self-service action.
            /// Required: Yes
            /// Type: List of DefinitionParameter
            /// Update requires: No interruption
            /// </summary>
            public List<DefinitionParameter> Definition { get; set; }

            /// <summary>
            /// Description
            /// The self-service action description.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalog::ServiceAction";

        public ServiceActionProperties Properties { get; } = new ServiceActionProperties();

    }

    public static class ServiceActionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
