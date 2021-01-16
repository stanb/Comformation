using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project Artifacts
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html
    /// </summary>
    public class Artifacts
    {

        /// <summary>
        /// Path
        /// Along with namespaceType and name, the pattern that AWS CodeBuild uses to name and store the output
        /// artifact:
        /// If type is set to CODEPIPELINE, AWS CodePipeline ignores this value if specified. This is because
        /// AWS CodePipeline manages its build output names instead of AWS CodeBuild. If type is set to
        /// NO_ARTIFACTS, this value is ignored if specified, because no build output is produced. If type is
        /// set to S3, this is the path to the output artifact. If path is not specified, path is not used.
        /// For example, if path is set to MyArtifacts, namespaceType is set to NONE, and name is set to
        /// MyArtifact. zip, the output artifact is stored in the output bucket at MyArtifacts/MyArtifact. zip.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Type
        /// The type of build output artifact. Valid values include:
        /// CODEPIPELINE: The build project has build output generated through AWS CodePipeline. Note The
        /// CODEPIPELINE type is not supported for secondaryArtifacts. NO_ARTIFACTS: The build project does not
        /// produce any build output. S3: The build project stores build output in Amazon Simple Storage Service
        /// (Amazon S3).
        /// Required: Yes
        /// Type: String
        /// Allowed values: CODEPIPELINE | NO_ARTIFACTS | S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ArtifactIdentifier
        /// An identifier for this artifact definition.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArtifactIdentifier")]
        public Union<string, IntrinsicFunction> ArtifactIdentifier { get; set; }

        /// <summary>
        /// OverrideArtifactName
        /// If set to true a name specified in the buildspec file overrides the artifact name. The name
        /// specified in a buildspec file is calculated at build time and uses the Shell command language. For
        /// example, you can append a date and time to your artifact name so that it is always unique.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OverrideArtifactName")]
        public Union<bool, IntrinsicFunction> OverrideArtifactName { get; set; }

        /// <summary>
        /// Packaging
        /// The type of build output artifact to create:
        /// If type is set to CODEPIPELINE, AWS CodePipeline ignores this value if specified. This is because
        /// AWS CodePipeline manages its build output artifacts instead of AWS CodeBuild. If type is set to
        /// NO_ARTIFACTS, this value is ignored if specified, because no build output is produced. If type is
        /// set to S3, valid values include: NONE: AWS CodeBuild creates in the output bucket a folder that
        /// contains the build output. This is the default if packaging is not specified. ZIP: AWS CodeBuild
        /// creates in the output bucket a ZIP file that contains the build output.
        /// Required: No
        /// Type: String
        /// Allowed values: NONE | ZIP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Packaging")]
        public Union<string, IntrinsicFunction> Packaging { get; set; }

        /// <summary>
        /// EncryptionDisabled
        /// Set to true if you do not want your output artifacts encrypted. This option is valid only if your
        /// artifacts type is Amazon Simple Storage Service (Amazon S3). If this is set with another artifacts
        /// type, an invalidInputException is thrown.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionDisabled")]
        public Union<bool, IntrinsicFunction> EncryptionDisabled { get; set; }

        /// <summary>
        /// Location
        /// Information about the build output artifact location:
        /// If type is set to CODEPIPELINE, AWS CodePipeline ignores this value if specified. This is because
        /// AWS CodePipeline manages its build output locations instead of AWS CodeBuild. If type is set to
        /// NO_ARTIFACTS, this value is ignored if specified, because no build output is produced. If type is
        /// set to S3, this is the name of the output bucket.
        /// If you specify CODEPIPELINE or NO_ARTIFACTS for the Type property, don&#39;t specify this property. For
        /// all of the other types, you must specify this property.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

        /// <summary>
        /// Name
        /// Along with path and namespaceType, the pattern that AWS CodeBuild uses to name and store the output
        /// artifact:
        /// If type is set to CODEPIPELINE, AWS CodePipeline ignores this value if specified. This is because
        /// AWS CodePipeline manages its build output names instead of AWS CodeBuild. If type is set to
        /// NO_ARTIFACTS, this value is ignored if specified, because no build output is produced. If type is
        /// set to S3, this is the name of the output artifact object. If you set the name to be a forward slash
        /// (&quot;/&quot;), the artifact is stored in the root of the output bucket.
        /// For example:
        /// If path is set to MyArtifacts, namespaceType is set to BUILD_ID, and name is set to MyArtifact. zip,
        /// then the output artifact is stored in MyArtifacts/build-ID/MyArtifact. zip. If path is empty,
        /// namespaceType is set to NONE, and name is set to &quot;/&quot;, the output artifact is stored in the root of
        /// the output bucket. If path is set to MyArtifacts, namespaceType is set to BUILD_ID, and name is set
        /// to &quot;/&quot;, the output artifact is stored in MyArtifacts/build-ID .
        /// If you specify CODEPIPELINE or NO_ARTIFACTS for the Type property, don&#39;t specify this property. For
        /// all of the other types, you must specify this property.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// NamespaceType
        /// Along with path and name, the pattern that AWS CodeBuild uses to determine the name and location to
        /// store the output artifact:
        /// If type is set to CODEPIPELINE, AWS CodePipeline ignores this value if specified. This is because
        /// AWS CodePipeline manages its build output names instead of AWS CodeBuild. If type is set to
        /// NO_ARTIFACTS, this value is ignored if specified, because no build output is produced. If type is
        /// set to S3, valid values include: BUILD_ID: Include the build ID in the location of the build output
        /// artifact. NONE: Do not include the build ID. This is the default if namespaceType is not specified.
        /// For example, if path is set to MyArtifacts, namespaceType is set to BUILD_ID, and name is set to
        /// MyArtifact. zip, the output artifact is stored in MyArtifacts/&amp;lt;build-ID&amp;gt;/MyArtifact. zip.
        /// Required: No
        /// Type: String
        /// Allowed values: BUILD_ID | NONE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NamespaceType")]
        public Union<string, IntrinsicFunction> NamespaceType { get; set; }

    }
}
