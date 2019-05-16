using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    /// AWS::ECR::Repository
    /// The AWS::ECR::Repository resource specifies an Amazon Elastic Container Registry (Amazon ECR) repository,
    /// where users can push and pull Docker images. For more information, see Amazon ECR Repositories in the Amazon
    /// Elastic Container Registry User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            /// LifecyclePolicy
            /// Creates or updates a lifecycle policy. For information about lifecycle policy syntax, see Lifecycle
            /// Policy Template.
            /// Required: No
            /// Type: LifecyclePolicy
            /// Update requires: No interruption
            /// </summary>
			public LifecyclePolicy LifecyclePolicy { get; set; }

            /// <summary>
            /// RepositoryName
            /// The name to use for the repository. The repository name may be specified on its own (such as
            /// nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such
            /// as project-a/nginx-web-app). If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the repository name. For more information, see Name Type.
            /// Note If you specify a name, you cannot perform updates that require replacement of this resource.
            /// You can perform updates that require no or some interruption. If you must replace the resource,
            /// specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 2
            /// Maximum: 256
            /// Pattern: (?:[a-z0-9]+(?:[. _-][a-z0-9]+)*/)*[a-z0-9]+(?:[. _-][a-z0-9]+)*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// RepositoryPolicyText
            /// The JSON repository policy text to apply to the repository. For more information, see Amazon ECR
            /// Repository Policy Examples in the Amazon Elastic Container Registry User Guide.
            /// Required: No
            /// Type: Json
            /// Minimum: 0
            /// Maximum: 10240
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RepositoryPolicyText { get; set; }

        }

        public string Type { get; } = "AWS::ECR::Repository";

        public RepositoryProperties Properties { get; } = new RepositoryProperties();

    }

	public static class RepositoryAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
