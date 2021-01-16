using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.Component
{
    /// <summary>
    /// AWS::ImageBuilder::Component
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-component.html
    /// </summary>
    public class ComponentResource : ResourceBase
    {
        public class ComponentProperties
        {
            /// <summary>
            /// Name
            /// The name of the component.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[-_A-Za-z-0-9][-_A-Za-z0-9 ]{1,126}[-_A-Za-z-0-9]$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Version
            /// The component version. For example, 1. 0. 0.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[0-9]+\. [0-9]+\. [0-9]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// Description
            /// The description of the component.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ChangeDescription
            /// A change description of the component. For example initial version.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ChangeDescription { get; set; }

            /// <summary>
            /// Platform
            /// The platform of the component. For example, Windows.
            /// Required: Yes
            /// Type: String
            /// Allowed values: Linux | Windows
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Platform { get; set; }

            /// <summary>
            /// Data
            /// The data of the component. For example, name: HelloWorldTestingDocument\ndescription: This is hello
            /// world testing document. \nschemaVersion: 1. 0\n\nphases:\n - name: test\n steps:\n - name:
            /// HelloWorldStep\n action: ExecuteBash\n inputs:\n commands:\n - echo \&quot;Hello World! Test. \&quot;\n. See
            /// Examples below for the schema for creating a component using Data.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Data { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The KMS key identifier used to encrypt the component.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// Tags
            /// The tags associated with the component.
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

            /// <summary>
            /// Uri
            /// The URI of the component document.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Uri { get; set; }

            /// <summary>
            /// SupportedOsVersions
            /// The operating system (OS) version supported by the component. If the OS information is available, a
            /// prefix match is performed against the parent image OS version during image recipe creation.
            /// Required: No
            /// Type: List of String
            /// Maximum: 25
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SupportedOsVersions { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::Component";

        public ComponentProperties Properties { get; } = new ComponentProperties();

    }

    public static class ComponentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Type = new ResourceAttribute<Union<string, IntrinsicFunction>>("Type");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> Encrypted = new ResourceAttribute<Union<bool, IntrinsicFunction>>("Encrypted");
    }
}
