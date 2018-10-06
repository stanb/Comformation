using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Document
{
    /// <summary>
    /// AWS::SSM::Document
    /// The AWS::SSM::Document resource creates an SSM document in AWS Systems Manager that describes an instance
    /// configuration, which you can use to set up and run commands on your instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html
    /// </summary>
    public class DocumentResource : ResourceBase
    {
        public class DocumentProperties
        {
            /// <summary>
            /// Content
            /// A JSON object that describes an instance configuration. For more information, see Creating Systems
            /// Manager Documents in the AWS Systems Manager User Guide.
            /// Note The Content property is a non-stringified property. For more information about automation
            /// actions, see Systems Manager Automation Document Reference in the AWS Systems Manager User Guide.
            /// Required: Yes
            /// Type: JSON object
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Content { get; set; }

            /// <summary>
            /// DocumentType
            /// The type of document to create that relates to the purpose of your document, such as running
            /// commands, bootstrapping software, or automating tasks. For valid values, see the CreateDocument
            /// action in the AWS Systems Manager API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DocumentType { get; set; }

            /// <summary>
            /// Tags
            /// AWS CloudFormation resource tags to apply to the document, which can help you identify and
            /// categorize these resources.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::SSM::Document";
        
        public DocumentProperties Properties { get; } = new DocumentProperties();

    }
}
