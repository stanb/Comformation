using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project EnvironmentVariable
    /// EnvironmentVariable is a property of the AWS CodeBuild Project Environment property type that specifies the
    /// name and value of an environment variable for an AWS CodeBuild project environment. When you use the
    /// environment to run a build, these variables are available for your builds to use. EnvironmentVariable contains
    /// a list of EnvironmentVariable property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environmentvariable.html
    /// </summary>
    public class EnvironmentVariable
    {

        /// <summary>
        /// Type
        /// The type of environment variable. Valid values include:
        /// PARAMETER_STORE: An environment variable stored in Amazon EC2 Systems Manager Parameter Store.
        /// PLAINTEXT: An environment variable in plaintext format.
        /// Required: No
        /// Type: String
        /// Allowed Values: PARAMETER_STORE | PLAINTEXT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The value of the environment variable.
        /// Important We strongly discourage the use of environment variables to store sensitive values,
        /// especially AWS secret key IDs and secret access keys. Environment variables can be displayed in
        /// plain text using the AWS CodeBuild console and the AWS Command Line Interface (AWS CLI).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name or key of the environment variable.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
