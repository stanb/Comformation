using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project
    /// The AWS::CodeBuild::Project resource configures how AWS CodeBuild builds your source code. For example, it
    /// tells AWS CodeBuild where to get the source code and which build environment to use.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// Description
            /// A description of the project. Use the description to identify the purpose of the project.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// VpcConfig
            /// Settings that enable AWS CodeBuild to access resources in an Amazon VPC. For more information, see
            /// Use AWS CodeBuild with Amazon Virtual Private Cloud in the AWS CodeBuild User Guide.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: No interruption
            /// </summary>
			public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// SecondarySources
            /// An array of source objects. Each source object contains source code settings for the project.
            /// Required: No
            /// Type: List of AWS CodeBuild Project Source
            /// Update requires: No interruption
            /// </summary>
			public List<Source> SecondarySources { get; set; }

            /// <summary>
            /// EncryptionKey
            /// The alias or Amazon Resource Name (ARN) of the AWS Key Management Service (AWS KMS) customer master
            /// key (CMK) that AWS CodeBuild uses to encrypt the build output. If you don&#39;t specify a value, AWS
            /// CodeBuild uses the AWS-managed CMK for Amazon Simple Storage Service.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EncryptionKey { get; set; }

            /// <summary>
            /// Triggers
            /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub repository,
            /// enables AWS CodeBuild to begin automatically rebuilding the source code every time a code change is
            /// pushed to the repository.
            /// Required: No
            /// Type: AWS CodeBuild Project ProjectTriggers
            /// Update requires: No interruption
            /// </summary>
			public ProjectTriggers Triggers { get; set; }

            /// <summary>
            /// SecondaryArtifacts
            /// An array of artifacts objects. Each artifacts object specifies output settings that the project
            /// generates during a build.
            /// Required: No
            /// Type: List of AWS CodeBuild Project Artifacts
            /// Update requires: No interruption
            /// </summary>
			public List<Artifacts> SecondaryArtifacts { get; set; }

            /// <summary>
            /// Source
            /// The source code settings for the project, such as the source code&#39;s repository type and location.
            /// Required: Yes
            /// Type: AWS CodeBuild Project Source
            /// Update requires: No interruption
            /// </summary>
			public Source Source { get; set; }

            /// <summary>
            /// Name
            /// A name for the project. The name must be unique across all of the projects in your AWS account.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Artifacts
            /// The output settings for artifacts that the project generates during a build.
            /// Required: Yes
            /// Type: AWS CodeBuild Project Artifacts
            /// Update requires: No interruption
            /// </summary>
			public Artifacts Artifacts { get; set; }

            /// <summary>
            /// BadgeEnabled
            /// Indicates whether AWS CodeBuild generates a publicly accessible URL for your project&#39;s build badge.
            /// For more information, see Build Badges Sample in the AWS CodeBuild User Guide.
            /// Note Including build badges with your project is currently not supported if the source type is AWS
            /// CodePipeline. If you specify CODEPIPELINE for the Source property, don&#39;t specify the BadgeEnabled
            /// property.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> BadgeEnabled { get; set; }

            /// <summary>
            /// LogsConfig
            /// Information about logs for this build project.
            /// Required: No
            /// Type: AWS CodeBuild Project LogsConfig
            /// Update requires: No interruption
            /// </summary>
			public LogsConfig LogsConfig { get; set; }

            /// <summary>
            /// ServiceRole
            /// The ARN of the service role that AWS CodeBuild uses to interact with services on your behalf.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// QueuedTimeoutInMinutes
            /// </summary>
			public Union<int, IntrinsicFunction> QueuedTimeoutInMinutes { get; set; }

            /// <summary>
            /// Environment
            /// The build environment settings for the project, such as the environment type or the environment
            /// variables to use for the build environment.
            /// Required: Yes
            /// Type: AWS CodeBuild Project Environment
            /// Update requires: No interruption
            /// </summary>
			public Environment Environment { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for the AWS CodeBuild project.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TimeoutInMinutes
            /// The number of minutes after which AWS CodeBuild stops the build if it&#39;s not complete. For valid
            /// values, see the timeoutInMinutes field in the AWS CodeBuild User Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> TimeoutInMinutes { get; set; }

            /// <summary>
            /// Cache
            /// Settings that AWS CodeBuild uses to store and reuse build dependencies.
            /// Required: No
            /// Type: ProjectCache
            /// Update requires: No interruption
            /// </summary>
			public ProjectCache Cache { get; set; }

        }

        public string Type { get; } = "AWS::CodeBuild::Project";

        public ProjectProperties Properties { get; } = new ProjectProperties();

    }

	public static class ProjectAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
