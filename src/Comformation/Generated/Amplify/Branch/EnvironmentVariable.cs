using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Branch
{
    /// <summary>
    /// AWS::Amplify::Branch EnvironmentVariable
    /// The EnvironmentVariable property type sets environment variables for a specific branch. Environment variables
    /// are key-value pairs that are available at build time.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-environmentvariable.html
    /// </summary>
    public class EnvironmentVariable
    {

        /// <summary>
        /// Value
        /// The environment variable value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The environment variable name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
