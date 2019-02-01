using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project Environment
    /// Environment is a property of the AWS::CodeBuild::Project resource that specifies the environment for an AWS
    /// CodeBuild project.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Type
        /// The type of build environment. For valid values, see the environment-type field in the AWS CodeBuild
        /// User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// EnvironmentVariables
        /// The environment variables that your builds can use. For more information, see the
        /// environmentVariables field in the AWS CodeBuild User Guide.
        /// Required: No
        /// Type: List of EnvironmentVariable
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public List<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// PrivilegedMode
        /// Indicates how the project builds Docker images. Specify true to enable running the Docker daemon
        /// inside a Docker container.
        /// This value must be set to true only if this build project will be used to build Docker images, and
        /// the specified build environment image is not one provided by AWS CodeBuild with Docker support.
        /// Otherwise, all associated builds that attempt to interact with the Docker daemon will fail. For more
        /// information, see the privilegedMode field in the AWS CodeBuild User Guide.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("PrivilegedMode")]
        public Union<bool, IntrinsicFunction> PrivilegedMode { get; set; }

        /// <summary>
        /// ImagePullCredentialsType
        /// The type of credentials AWS CodeBuild uses to pull images in your build. There are two valid values:
        /// CODEBUILD specifies that AWS CodeBuild uses its own credentials. This requires that you modify your
        /// ECR repository policy to trust the AWS CodeBuild service principal. SERVICE_ROLE specifies that AWS
        /// CodeBuild uses your build project&#39;s service role.
        /// When you use a cross-account or private registry image, you must use SERVICE_ROLE credentials. When
        /// you use an AWS CodeBuild curated image, you must use CODEBUILD credentials.
        /// The Docker image identifier that the build environment uses. For more information, see the
        /// imagePullCredentialsType field in the AWS CodeBuild User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ImagePullCredentialsType")]
        public Union<string, IntrinsicFunction> ImagePullCredentialsType { get; set; }

        /// <summary>
        /// Image
        /// The image tag or image digest that identifies the Docker image to use for this build project. Use
        /// the following formats:
        /// For an image tag: registry/repository:tag. For example, to specify an image with the tag &quot;latest,&quot;
        /// use registry/repository:latest. For an image digest: registry/repository@digest. For example, to
        /// specify an image with the digest
        /// &quot;sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf,&quot; use
        /// registry/repository@sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf.
        /// For more information, see the image field in the AWS CodeBuild User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// RegistryCredential
        /// RegistryCredential is a property of the AWS::CodeBuild::Project resource that specifies information
        /// about credentials that provide access to a private Docker registry. When this is set:
        /// imagePullCredentialsType must be set to SERVICE_ROLE. images cannot be curated or an Amazon ECR
        /// image.
        /// For more information, see the RegistryCredential field in the AWS CodeBuild User Guide.
        /// Required: No
        /// Type: RegistryCredential
        /// </summary>
        [JsonProperty("RegistryCredential")]
        public RegistryCredential RegistryCredential { get; set; }

        /// <summary>
        /// ComputeType
        /// The type of compute environment, such as BUILD_GENERAL1_SMALL. The compute type determines the
        /// number of CPU cores and memory the build environment uses. For valid values, see the computeType
        /// field in the AWS CodeBuild User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ComputeType")]
        public Union<string, IntrinsicFunction> ComputeType { get; set; }

        /// <summary>
        /// Certificate
        /// The certificate to use with the build project.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Certificate")]
        public Union<string, IntrinsicFunction> Certificate { get; set; }

    }
}
