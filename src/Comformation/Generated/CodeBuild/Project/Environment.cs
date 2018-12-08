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
        /// Type: List of AWS CodeBuild Project EnvironmentVariable
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
        /// Image
        /// The Docker image identifier that the build environment uses. For more information, see the image
        /// field in the AWS CodeBuild User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

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
