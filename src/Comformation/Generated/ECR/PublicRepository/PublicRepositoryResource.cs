using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.PublicRepository
{
    /// <summary>
    /// AWS::ECR::PublicRepository
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-publicrepository.html
    /// </summary>
    public class PublicRepositoryResource : ResourceBase
    {
        public class PublicRepositoryProperties
        {
            /// <summary>
            /// RepositoryName
            /// The name to use for the public repository. The repository name may be specified on its own (such as
            /// nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such
            /// as project-a/nginx-web-app). If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the repository name. For more information, see Name Type.
            /// Note If you specify a name, you cannot perform updates that require replacement of this resource.
            /// You can perform updates that require no or some interruption. If you must replace the resource,
            /// specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// RepositoryPolicyText
            /// The JSON repository policy text to apply to the public repository. For more information, see Amazon
            /// ECR Public repository policies in the Amazon ECR Public User Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RepositoryPolicyText { get; set; }

            /// <summary>
            /// RepositoryCatalogData
            /// The details about the repository that are publicly visible in the Amazon ECR Public Gallery. For
            /// more information, see Amazon ECR Public repository catalog data in the Amazon ECR Public User Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RepositoryCatalogData { get; set; }

        }

        public string Type { get; } = "AWS::ECR::PublicRepository";

        public PublicRepositoryProperties Properties { get; } = new PublicRepositoryProperties();

    }

    public static class PublicRepositoryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
