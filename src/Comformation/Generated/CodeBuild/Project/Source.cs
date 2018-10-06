using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project Source
    /// Source is a property of the AWS::CodeBuild::Project resource that specifies the source code settings for an
    /// AWS CodeBuild project.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// Type
        /// The type of repository that contains your source code. For valid values, see the source-type field
        /// in the AWS CodeBuild User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ReportBuildStatus
        /// This specifies whether to send your source provider the status of a build&#39;s start and completion. If
        /// you set this with a source provider other than GitHub, an invalidInputException is thrown.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("ReportBuildStatus")]
        public Union<bool, IntrinsicFunction> ReportBuildStatus { get; set; }

        /// <summary>
        /// Auth
        /// Information about the authorization settings for AWS CodeBuild to access the source code to be
        /// built.
        /// Note Your code shouldn&#39;t get or set this information directly unless the project&#39;s source type is
        /// GITHUB.
        /// Required: No
        /// Type: AWS CodeBuild Project SourceAuth
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Auth")]
        public SourceAuth Auth { get; set; }

        /// <summary>
        /// SourceIdentifier
        /// </summary>
        [JsonProperty("SourceIdentifier")]
        public Union<string, IntrinsicFunction> SourceIdentifier { get; set; }

        /// <summary>
        /// BuildSpec
        /// The build specification for the project. If this value is not provided, then the source code must
        /// contain a build spec file named buildspec. yml at the root level. If this value is provided, it can
        /// be either a single string containing the entire build specification, or the path to an alternate
        /// build spec file relative to the value of the built-in environment variable CODEBUILD_SRC_DIR. The
        /// alternate build spec file can have a name other than buildspec. yml, for example myspec. yml or
        /// build_spec_qa. yml or similar. For more information, see the Build Spec Reference in the AWS
        /// CodeBuild User Guide.
        /// Required: No
        /// Type: String
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
        /// </summary>
        [JsonProperty("GitCloneDepth")]
        public Union<int, IntrinsicFunction> GitCloneDepth { get; set; }

        /// <summary>
        /// InsecureSsl
        /// This is used with GitHub Enterprise only. Set to true to ignore SSL warnings while connecting to
        /// your GitHub Enterprise project repository. The default value is false. InsecureSsl should be used
        /// for testing purposes only. It should not be used in a production environment.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("InsecureSsl")]
        public Union<bool, IntrinsicFunction> InsecureSsl { get; set; }

        /// <summary>
        /// Location
        /// The location of the source code in the specified repository type. For more information, see the
        /// source-location field in the AWS CodeBuild User Guide.
        /// Required: Conditional. If you specify CODEPIPELINE for the Type property, don&#39;t specify this
        /// property. For all of the other types, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
