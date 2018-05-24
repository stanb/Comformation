using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-lifecyclepolicy
            /// </summary>
			public Union<LifecyclePolicy, IntrinsicFunction> LifecyclePolicy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-repositoryname
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-repositorypolicytext
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
