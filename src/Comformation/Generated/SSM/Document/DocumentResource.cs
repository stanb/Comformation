using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Document
{
    /// <summary>
    /// AWS::SSM::Document
    /// The AWS::SSM::Document resource creates an SSM document in AWS Systems Manager that defines the actions that
    /// Systems Manager performs, which you can use to set up and run commands on your instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html
    /// </summary>
    public class DocumentResource : ResourceBase
    {
        public class DocumentProperties
        {
            /// <summary>
            /// Content
            /// A valid JSON or YAML string.
            /// Required: Yes
            /// Type: Json
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Content { get; set; }

            /// <summary>
            /// DocumentType
            /// The type of document to create. Valid document types include: Command, Policy, Automation, Session,
            /// and Package.
            /// Required: No
            /// Type: String
            /// Allowed Values: Automation | Command | Package | Policy | Session
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DocumentType { get; set; }

            /// <summary>
            /// Tags
            /// AWS CloudFormation resource tags to apply to the document, which can help you identify and
            /// categorize these resources.
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
