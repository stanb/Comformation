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
            /// The content for the new SSM document in JSON or YAML.
            /// Note This parameter also supports String data types.
            /// Required: Yes
            /// Type: Json
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Content { get; set; }

            /// <summary>
            /// Attachments
            /// A list of key-value pairs that describe attachments to a version of a document.
            /// Required: No
            /// Type: List of AttachmentsSource
            /// Maximum: 20
            /// Update requires: Replacement
            /// </summary>
            public List<AttachmentsSource> Attachments { get; set; }

            /// <summary>
            /// Name
            /// A name for the SSM document.
            /// Important You can&#39;t use the following strings as document name prefixes. These are reserved by AWS
            /// for use as document name prefixes: aws- amazon amzn
            /// Required: No
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// VersionName
            /// An optional field specifying the version of the artifact you are creating with the document. For
            /// example, &quot;Release 12, Update 6&quot;. This value is unique across all versions of a document, and can&#39;t
            /// be changed.
            /// Required: No
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_\-. ]{1,128}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VersionName { get; set; }

            /// <summary>
            /// DocumentType
            /// The type of document to create.
            /// Allowed Values: ApplicationConfigurationSchema | Automation | Automation. ChangeTemplate | Command |
            /// DeploymentStrategy | Package | Policy | Session
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DocumentType { get; set; }

            /// <summary>
            /// DocumentFormat
            /// Specify the document format for the request. The document format can be JSON or YAML. JSON is the
            /// default format.
            /// Note TEXT is not supported, even though it is listed in the Allowed values.
            /// Required: No
            /// Type: String
            /// Allowed values: JSON | TEXT | YAML
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DocumentFormat { get; set; }

            /// <summary>
            /// TargetType
            /// Specify a target type to define the kinds of resources the document can run on. For example, to run
            /// a document on EC2 instances, specify the following value: /AWS::EC2::Instance. If you specify a
            /// value of &#39;/&#39; the document can run on all types of resources. If you don&#39;t specify a value, the
            /// document can&#39;t run on any resources. For a list of valid resource types, see AWS resource and
            /// property types reference in the AWS CloudFormation User Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Pattern: ^\/[\w\. \-\:\/]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetType { get; set; }

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

            /// <summary>
            /// Requires
            /// A list of SSM documents required by a document. This parameter is used exclusively by AWS AppConfig.
            /// When a user creates an AWS AppConfig configuration in an SSM document, the user must also specify a
            /// required document for validation purposes. In this case, an ApplicationConfiguration document
            /// requires an ApplicationConfigurationSchema document for validation purposes. For more information,
            /// see What is AWS AppConfig? in the AWS AppConfig User Guide.
            /// Required: No
            /// Type: List of DocumentRequires
            /// Update requires: Replacement
            /// </summary>
            public List<DocumentRequires> Requires { get; set; }

        }

        public string Type { get; } = "AWS::SSM::Document";

        public DocumentProperties Properties { get; } = new DocumentProperties();

    }
}
