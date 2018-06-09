using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    /// AWS::ECR::Repository
    /// The AWS::ECR::Repository resource creates an Amazon Elastic Container Registry (Amazon ECR) repository, where
    /// users can push and pull Docker images. For more information, see Amazon ECR Repositories in the Amazon Elastic
    /// Container Registry User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            /// LifecyclePolicy
            /// A lifecycle policy for the repository.
            /// Required: No
            /// Type: Amazon ECR Repository LifecyclePolicy
            /// Update requires: No interruption
            /// </summary>
			public Union<LifecyclePolicy, IntrinsicFunction> LifecyclePolicy { get; set; }

            /// <summary>
            /// RepositoryName
            /// A name for the image repository. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the repository name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// RepositoryPolicyText
            /// A policy that controls who has access to the repository and which actions they can perform on it.
            /// For more information, see Amazon ECR Repository Policies in the Amazon Elastic Container Registry
            /// User Guide.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RepositoryPolicyText { get; set; }

        }
    
        public string Type { get; } = "AWS::ECR::Repository";
        
        public RepositoryProperties Properties { get; } = new RepositoryProperties();
    }

	public static class RepositoryAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
