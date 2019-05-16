using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project Source
    /// Source is a property of the AWS::CodeBuild::Project resource that specifies the source code settings for the
    /// project, such as the source code&#39;s repository type and location.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// Type
        /// The type of repository that contains the source code to be built. Valid values include:
        /// BITBUCKET: The source code is in a Bitbucket repository. CODECOMMIT: The source code is in an AWS
        /// CodeCommit repository. CODEPIPELINE: The source code settings are specified in the source action of
        /// a pipeline in AWS CodePipeline. GITHUB: The source code is in a GitHub repository. NO_SOURCE: The
        /// project does not have input source code. S3: The source code is in an Amazon Simple Storage Service
        /// (Amazon S3) input bucket.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: BITBUCKET | CODECOMMIT | CODEPIPELINE | GITHUB | GITHUB_ENTERPRISE | NO_SOURCE | S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ReportBuildStatus
        /// Set to true to report the status of a build&#39;s start and finish to your source provider. This option
        /// is valid only when your source provider is GitHub, GitHub Enterprise, or Bitbucket. If this is set
        /// and you use a different source provider, an invalidInputException is thrown.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReportBuildStatus")]
        public Union<bool, IntrinsicFunction> ReportBuildStatus { get; set; }

        /// <summary>
        /// Auth
        /// Information about the authorization settings for AWS CodeBuild to access the source code to be
        /// built.
        /// This information is for the AWS CodeBuild console&#39;s use only. Your code should not get or set Auth
        /// directly.
        /// Required: No
        /// Type: SourceAuth
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Auth")]
        public SourceAuth Auth { get; set; }

        /// <summary>
        /// SourceIdentifier
        /// An identifier for this project source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceIdentifier")]
        public Union<string, IntrinsicFunction> SourceIdentifier { get; set; }

        /// <summary>
        /// BuildSpec
        /// The build specification for the project. If this value is not provided, then the source code must
        /// contain a buildspec file named buildspec. yml at the root level. If this value is provided, it can
        /// be either a single string containing the entire build specification, or the path to an alternate
        /// buildspec file relative to the value of the built-in environment variable CODEBUILD_SRC_DIR. The
        /// alternate buildspec file can have a name other than buildspec. yml, for example myspec. yml or
        /// build_spec_qa. yml or similar. For more information, see the Build Spec Reference in the AWS
        /// CodeBuild User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BuildSpec")]
        public Union<string, IntrinsicFunction> BuildSpec { get; set; }

        /// <summary>
        /// GitCloneDepth
        /// The depth of history to download. Minimum value is 0. If this value is 0, greater than 25, or not
        /// provided, then the full history is downloaded with each build project. If your source type is Amazon
        /// S3, this value is not supported.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GitCloneDepth")]
        public Union<int, IntrinsicFunction> GitCloneDepth { get; set; }

        /// <summary>
        /// GitSubmodulesConfig
        /// Information about the Git submodules configuration for the build project.
        /// Required: No
        /// Type: GitSubmodulesConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GitSubmodulesConfig")]
        public GitSubmodulesConfig GitSubmodulesConfig { get; set; }

        /// <summary>
        /// InsecureSsl
        /// This is used with GitHub Enterprise only. Set to true to ignore SSL warnings while connecting to
        /// your GitHub Enterprise project repository. The default value is false. InsecureSsl should be used
        /// for testing purposes only. It should not be used in a production environment.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InsecureSsl")]
        public Union<bool, IntrinsicFunction> InsecureSsl { get; set; }

        /// <summary>
        /// Location
        /// Information about the location of the source code to be built. Valid values include:
        /// For source code settings that are specified in the source action of a pipeline in AWS CodePipeline,
        /// location should not be specified. If it is specified, AWS CodePipeline ignores it. This is because
        /// AWS CodePipeline uses the settings in a pipeline&#39;s source action instead of this value. For source
        /// code in an AWS CodeCommit repository, the HTTPS clone URL to the repository that contains the source
        /// code and the build spec (for example, https://git-codecommit. region-ID. amazonaws.
        /// com/v1/repos/repo-name ). For source code in an Amazon Simple Storage Service (Amazon S3) input
        /// bucket, one of the following. The path to the ZIP file that contains the source code (for example,
        /// bucket-name/path/to/object-name. zip). The path to the folder that contains the source code (for
        /// example, bucket-name/path/to/source-code/folder/). For source code in a GitHub repository, the HTTPS
        /// clone URL to the repository that contains the source and the build spec. You must connect your AWS
        /// account to your GitHub account. Use the AWS CodeBuild console to start creating a build project.
        /// When you use the console to connect (or reconnect) with GitHub, on the GitHub Authorize application
        /// page, for Organization access, choose Request access next to each repository you want to allow AWS
        /// CodeBuild to have access to, and then choose Authorize application. (After you have connected to
        /// your GitHub account, you do not need to finish creating the build project. You can leave the AWS
        /// CodeBuild console. ) To instruct AWS CodeBuild to use this connection, in the source object, set the
        /// auth object&#39;s type value to OAUTH. For source code in a Bitbucket repository, the HTTPS clone URL to
        /// the repository that contains the source and the build spec. You must connect your AWS account to
        /// your Bitbucket account. Use the AWS CodeBuild console to start creating a build project. When you
        /// use the console to connect (or reconnect) with Bitbucket, on the Bitbucket Confirm access to your
        /// account page, choose Grant access. (After you have connected to your Bitbucket account, you do not
        /// need to finish creating the build project. You can leave the AWS CodeBuild console. ) To instruct
        /// AWS CodeBuild to use this connection, in the source object, set the auth object&#39;s type value to
        /// OAUTH.
        /// If you specify CODEPIPELINE for the Type property, don&#39;t specify this property. For all of the other
        /// types, you must specify Location.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
