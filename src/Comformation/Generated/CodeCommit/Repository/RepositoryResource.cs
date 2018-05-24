using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-repositoryname
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-triggers
            /// </summary>
			public Union<List<RepositoryTrigger>, IntrinsicFunction> Triggers { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-repositorydescription
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryDescription { get; set; }

        }
    
        public string Type { get; } = "AWS::CodeCommit::Repository";
        
        public RepositoryProperties Properties { get; } = new RepositoryProperties();
    }

	public static class RepositoryAttributes
	{
        public static readonly ResourceAttribute<string> CloneUrlHttp = new ResourceAttribute<string>("CloneUrlHttp");
        public static readonly ResourceAttribute<string> CloneUrlSsh = new ResourceAttribute<string>("CloneUrlSsh");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
