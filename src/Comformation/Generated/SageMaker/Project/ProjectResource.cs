using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Project
{
    /// <summary>
    /// AWS::SageMaker::Project
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// Tags
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ProjectName
            /// The name of the project.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,31}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectName { get; set; }

            /// <summary>
            /// ProjectDescription
            /// The description of the project.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Pattern: [\p{L}\p{M}\p{Z}\p{S}\p{N}\p{P}]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectDescription { get; set; }

            /// <summary>
            /// ServiceCatalogProvisioningDetails
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ServiceCatalogProvisioningDetails { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Project";

        public ProjectProperties Properties { get; } = new ProjectProperties();

    }

    public static class ProjectAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>> ServiceCatalogProvisionedProductDetails = new ResourceAttribute<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>>("ServiceCatalogProvisionedProductDetails");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectStatus");
    }
}
