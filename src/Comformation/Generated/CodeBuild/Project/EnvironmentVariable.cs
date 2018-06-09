using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project EnvironmentVariable
    /// The EnvironmentVariable property type specifies the name and value of an environment variable for an AWS
    /// CodeBuild project environment. When you use the environment to run a build, these variables are available for
    /// your builds to use.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environmentvariable.html
    /// </summary>
    public class EnvironmentVariable
    {

        /// <summary>
        /// Type
        /// The type of environment variable. Valid values are:
        /// PARAMETER_STORE: An environment variable stored in Systems Manager Parameter Store. PLAINTEXT: An
        /// environment variable in plaintext format.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The value of the environment variable.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name of an environment variable.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
