using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS OpsWorks App Environment
    /// Environment is a property of the AWS::OpsWorks::App resource that specifies the environment variable to
    /// associate with the AWS OpsWorks app.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-app-environment.html
    /// </summary>
    public class EnvironmentVariable
    {

        /// <summary>
        /// Key
        /// The name of the environment variable, which can consist of up to 64 characters. You can use upper
        /// and lowercase letters, numbers, and underscores (_), but the name must start with a letter or
        /// underscore.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Secure
        /// Indicates whether the value of the environment variable is concealed, such as with a DescribeApps
        /// response. To conceal an environment variable&#39;s value, set the value to true.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Secure")]
        public Union<bool, IntrinsicFunction> Secure { get; set; }

        /// <summary>
        /// Value
        /// The value of the environment variable, which can be empty. You can specify a value of up to 256
        /// characters.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
