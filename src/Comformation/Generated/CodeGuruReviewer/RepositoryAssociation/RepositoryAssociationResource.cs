using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeGuruReviewer.RepositoryAssociation
{
    /// <summary>
    /// AWS::CodeGuruReviewer::RepositoryAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codegurureviewer-repositoryassociation.html
    /// </summary>
    public class RepositoryAssociationResource : ResourceBase
    {
        public class RepositoryAssociationProperties
        {
            /// <summary>
            /// Name
            /// The name of the repository.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^\S[\w. -]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Type
            /// The type of repository that contains the source code to be reviewed. The valid values are:
            /// CodeCommit Bitbucket GitHubEnterpriseServer S3Bucket
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Owner
            /// The owner of the repository. For a GitHub Enterprise Server or Bitbucket repository, this is the
            /// username for the account that owns the repository.
            /// Owner must be specified for Bitbucket and GitHub Enterprise Server repositories. It has no effect if
            /// it is specified for an AWS CodeCommit repository.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^\S(. *\S)?$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Owner { get; set; }

            /// <summary>
            /// BucketName
            /// The name of the bucket. This is required for your S3Bucket repositoryThe name must start with the
            /// prefix, codeguru-reviewer-*.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// ConnectionArn
            /// The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection. Its format is
            /// arn:aws:codestar-connections:region-id:aws-account_id:connection/connection-id. For more
            /// information, see Connection in the AWS CodeStar Connections API Reference.
            /// ConnectionArn must be specified for Bitbucket and GitHub Enterprise Server repositories. It has no
            /// effect if it is specified for an AWS CodeCommit repository.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: arn:aws(-[\w]+)*:. +:. +:[0-9]{12}:. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionArn { get; set; }

            /// <summary>
            /// Tags
            /// 			
            /// 				An array of key-value pairs used to tag an associated repository. A tag is a custom attribute
            /// label with two parts: 			
            /// 			
            /// 				 				 			 					 A tag key (for example, CostCenter, 						Environment, Project, or Secret). Tag
            /// 						keys are case sensitive. 				 					 An optional field known as a tag value (for example,
            /// 						111122223333, Production, or a team name). 						Omitting the tag value is the same as using
            /// an empty string. Like tag keys, tag 						values are case sensitive. 				
            /// 		 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CodeGuruReviewer::RepositoryAssociation";

        public RepositoryAssociationProperties Properties { get; } = new RepositoryAssociationProperties();

    }

    public static class RepositoryAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssociationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssociationArn");
    }
}
