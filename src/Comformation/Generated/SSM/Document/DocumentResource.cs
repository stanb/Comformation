using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Document
{
    /// <summary>
    /// AWS::SSM::Document
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html
    /// </summary>
    public class DocumentResource : ResourceBase
    {
        public class DocumentProperties
        {
            /// <summary>
            /// Content
            /// The content for the new SSM document in JSON or YAML format.
            /// Required: Yes
            /// Type: Json
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Content { get; set; }

            /// <summary>
            /// DocumentType
            /// The type of document to create.
            /// Allowed Values: ApplicationConfigurationSchema | Automation | ChangeCalendar | Command |
            /// DeploymentStrategy | Package | Policy | Session
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DocumentType { get; set; }

            /// <summary>
            /// Name
            /// A name for the Systems Manager document.
            /// Important You can&#39;t use the following strings as document name prefixes. These are reserved by AWS
            /// for use as document name prefixes: aws- amazon amzn
            /// Required: No
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// AWS CloudFormation resource tags to apply to the document. Use tags to help you identify and
            /// categorize resources.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SSM::Document";

        public DocumentProperties Properties { get; } = new DocumentProperties();

    }
}
