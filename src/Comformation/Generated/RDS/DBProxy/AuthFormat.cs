using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBProxy
{
    /// <summary>
    /// AWS::RDS::DBProxy AuthFormat
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-authformat.html
    /// </summary>
    public class AuthFormat
    {

        /// <summary>
        /// AuthScheme
        /// The type of authentication that the proxy uses for connections from the proxy to the underlying
        /// database.
        /// Valid Values: SECRETS
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthScheme")]
        public Union<string, IntrinsicFunction> AuthScheme { get; set; }

        /// <summary>
        /// Description
        /// A user-specified description about the authentication used by a proxy to log in as a specific
        /// database user.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// IAMAuth
        /// Whether to require or disallow AWS Identity and Access Management (IAM) authentication for
        /// connections to the proxy.
        /// Valid Values: DISABLED | REQUIRED
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IAMAuth")]
        public Union<string, IntrinsicFunction> IAMAuth { get; set; }

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) representing the secret that the proxy uses to authenticate to the
        /// RDS DB instance or Aurora DB cluster. These secrets are stored within Amazon Secrets Manager.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

        /// <summary>
        /// UserName
        /// The name of the database user to which the proxy connects.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserName")]
        public Union<string, IntrinsicFunction> UserName { get; set; }

    }
}
