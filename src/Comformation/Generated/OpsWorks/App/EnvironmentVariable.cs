using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS::OpsWorks::App EnvironmentVariable
    /// Represents an app&#39;s environment variable.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-app-environment.html
    /// </summary>
    public class EnvironmentVariable
    {

        /// <summary>
        /// Key
        /// (Required) The environment variable&#39;s name, which can consist of up to 64 characters and must be
        /// specified. The name can contain upper- and lowercase letters, numbers, and underscores (_), but it
        /// must start with a letter or underscore.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Secure
        /// (Optional) Whether the variable&#39;s value will be returned by the DescribeApps action. To conceal an
        /// environment variable&#39;s value, set Secure to true. DescribeApps then returns *****FILTERED*****
        /// instead of the actual value. The default value for Secure is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Secure")]
        public Union<bool, IntrinsicFunction> Secure { get; set; }

        /// <summary>
        /// Value
        /// (Optional) The environment variable&#39;s value, which can be left empty. If you specify a value, it can
        /// contain up to 256 characters, which must all be printable.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
