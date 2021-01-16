using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// Description
            /// A description that makes the build project easy to identify.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// VpcConfig
            /// VpcConfig specifies settings that enable AWS CodeBuild to access resources in an Amazon VPC. For
            /// more information, see Use AWS CodeBuild with Amazon Virtual Private Cloud in the AWS CodeBuild User
            /// Guide.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: No interruption
            /// </summary>
            public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// SecondarySources
            /// An array of ProjectSource objects.
            /// Required: No
            /// Type: List of Source
            /// Maximum: 12
            /// Update requires: No interruption
            /// </summary>
            public List<Source> SecondarySources { get; set; }

            /// <summary>
            /// EncryptionKey
            /// The alias or Amazon Resource Name (ARN) of the AWS Key Management Service (AWS KMS) customer master
            /// key (CMK) that CodeBuild uses to encrypt the build output. If you don&#39;t specify a value, CodeBuild
            /// uses the AWS-managed CMK for Amazon Simple Storage Service (Amazon S3).
            /// Note You can use a cross-account KMS key to encrypt the build output artifacts if your service role
            /// has permission to that key.
            /// You can specify either the Amazon Resource Name (ARN) of the CMK or, if available, the CMK&#39;s alias
            /// (using the format alias/alias-name ).
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EncryptionKey { get; set; }

            /// <summary>
            /// SourceVersion
            /// A version of the build input to be built for this project. If not specified, the latest version is
            /// used. If specified, it must be one of:
            /// For AWS CodeCommit: the commit ID, branch, or Git tag to use. For GitHub: the commit ID, pull
            /// request ID, branch name, or tag name that corresponds to the version of the source code you want to
            /// build. If a pull request ID is specified, it must use the format pr/pull-request-ID (for example
            /// pr/25). If a branch name is specified, the branch&#39;s HEAD commit ID is used. If not specified, the
            /// default branch&#39;s HEAD commit ID is used. For Bitbucket: the commit ID, branch name, or tag name that
            /// corresponds to the version of the source code you want to build. If a branch name is specified, the
            /// branch&#39;s HEAD commit ID is used. If not specified, the default branch&#39;s HEAD commit ID is used. For
            /// Amazon Simple Storage Service (Amazon S3): the version ID of the object that represents the build
            /// input ZIP file to use.
            /// If sourceVersion is specified at the build level, then that version takes precedence over this
            /// sourceVersion (at the project level).
            /// For more information, see Source Version Sample with CodeBuild in the AWS CodeBuild User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SourceVersion { get; set; }

            /// <summary>
            /// Triggers
            /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub repository,
            /// enables AWS CodeBuild to begin automatically rebuilding the source code every time a code change is
            /// pushed to the repository.
            /// Required: No
            /// Type: ProjectTriggers
            /// Update requires: No interruption
            /// </summary>
            public ProjectTriggers Triggers { get; set; }

            /// <summary>
            /// SecondaryArtifacts
            /// A list of Artifacts objects. Each artifacts object specifies output settings that the project
            /// generates during a build.
            /// Required: No
            /// Type: List of Artifacts
            /// Maximum: 12
            /// Update requires: No interruption
            /// </summary>
            public List<Artifacts> SecondaryArtifacts { get; set; }

            /// <summary>
            /// Source
            /// The source code settings for the project, such as the source code&#39;s repository type and location.
            /// Required: Yes
            /// Type: Source
            /// Update requires: No interruption
            /// </summary>
            public Source Source { get; set; }

            /// <summary>
            /// Name
            /// The name of the build project. The name must be unique across all of the projects in your AWS
            /// account.
            /// Required: No
            /// Type: String
            /// Minimum: 2
            /// Maximum: 255
            /// Pattern: [A-Za-z0-9][A-Za-z0-9\-_]{1,254}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Artifacts
            /// Artifacts is a property of the AWS::CodeBuild::Project resource that specifies output settings for
            /// artifacts generated by an AWS CodeBuild build.
            /// Required: Yes
            /// Type: Artifacts
            /// Update requires: No interruption
            /// </summary>
            public Artifacts Artifacts { get; set; }

            /// <summary>
            /// BadgeEnabled
            /// Indicates whether AWS CodeBuild generates a publicly accessible URL for your project&#39;s build badge.
            /// For more information, see Build Badges Sample in the AWS CodeBuild User Guide.
            /// Note Including build badges with your project is currently not supported if the source type is
            /// CodePipeline. If you specify CODEPIPELINE for the Source property, do not specify the BadgeEnabled
            /// property.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> BadgeEnabled { get; set; }

            /// <summary>
            /// LogsConfig
            /// Information about logs for the build project. A project can create logs in Amazon CloudWatch Logs,
            /// an S3 bucket, or both.
            /// Required: No
            /// Type: LogsConfig
            /// Update requires: No interruption
            /// </summary>
            public LogsConfig LogsConfig { get; set; }

            /// <summary>
            /// ServiceRole
            /// The ARN of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild to interact
            /// with dependent AWS services on behalf of the AWS account.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// QueuedTimeoutInMinutes
            /// The number of minutes a build is allowed to be queued before it times out.
            /// Required: No
            /// Type: Integer
            /// Minimum: 5
            /// Maximum: 480
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> QueuedTimeoutInMinutes { get; set; }

            /// <summary>
            /// FileSystemLocations
            /// An array of ProjectFileSystemLocation objects for a CodeBuild build project. A
            /// ProjectFileSystemLocation object specifies the identifier, location, mountOptions, mountPoint, and
            /// type of a file system created using Amazon Elastic File System.
            /// Required: No
            /// Type: List of ProjectFileSystemLocation
            /// Update requires: No interruption
            /// </summary>
            public List<ProjectFileSystemLocation> FileSystemLocations { get; set; }

            /// <summary>
            /// Environment
            /// The build environment settings for the project, such as the environment type or the environment
            /// variables to use for the build environment.
            /// Required: Yes
            /// Type: Environment
            /// Update requires: No interruption
            /// </summary>
            public Environment Environment { get; set; }

            /// <summary>
            /// SecondarySourceVersions
            /// An array of ProjectSourceVersion objects. If secondarySourceVersions is specified at the build
            /// level, then they take over these secondarySourceVersions (at the project level).
            /// Required: No
            /// Type: List of ProjectSourceVersion
            /// Maximum: 12
            /// Update requires: No interruption
            /// </summary>
            public List<ProjectSourceVersion> SecondarySourceVersions { get; set; }

            /// <summary>
            /// BuildBatchConfig
            /// A ProjectBuildBatchConfig object that defines the batch build options for the project.
            /// Required: No
            /// Type: ProjectBuildBatchConfig
            /// Update requires: No interruption
            /// </summary>
            public ProjectBuildBatchConfig BuildBatchConfig { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for the AWS CodeBuild project.
            /// These tags are available for use by AWS services that support AWS CodeBuild build project tags.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TimeoutInMinutes
            /// How long, in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait before timing out any
            /// related build that did not get marked as completed. The default is 60 minutes.
            /// Required: No
            /// Type: Integer
            /// Minimum: 5
            /// Maximum: 480
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
