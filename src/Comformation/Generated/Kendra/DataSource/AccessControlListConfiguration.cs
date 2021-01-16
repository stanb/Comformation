using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource AccessControlListConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-accesscontrollistconfiguration.html
    /// </summary>
    public class AccessControlListConfiguration
    {

        /// <summary>
        /// KeyPath
        /// Path to the AWS S3 bucket that contains the access control list files.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyPath")]
        public Union<string, IntrinsicFunction> KeyPath { get; set; }

    }
}
