using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint MongoDbSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html
    /// </summary>
    public class MongoDbSettings
    {

        /// <summary>
        /// Port
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// ExtractDocId
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExtractDocId")]
        public Union<string, IntrinsicFunction> ExtractDocId { get; set; }

        /// <summary>
        /// DatabaseName
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// AuthSource
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthSource")]
        public Union<string, IntrinsicFunction> AuthSource { get; set; }

        /// <summary>
        /// AuthMechanism
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Allowed values: default | mongodb_cr | scram_sha_1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthMechanism")]
        public Union<string, IntrinsicFunction> AuthMechanism { get; set; }

        /// <summary>
        /// Username
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// DocsToInvestigate
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocsToInvestigate")]
        public Union<string, IntrinsicFunction> DocsToInvestigate { get; set; }

        /// <summary>
        /// ServerName
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerName")]
        public Union<string, IntrinsicFunction> ServerName { get; set; }

        /// <summary>
        /// SecretsManagerSecretId
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretsManagerSecretId")]
        public Union<string, IntrinsicFunction> SecretsManagerSecretId { get; set; }

        /// <summary>
        /// AuthType
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Allowed values: no | password
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthType")]
        public Union<string, IntrinsicFunction> AuthType { get; set; }

        /// <summary>
        /// SecretsManagerAccessRoleArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretsManagerAccessRoleArn")]
        public Union<string, IntrinsicFunction> SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Password
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// NestingLevel
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Allowed values: none | one
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NestingLevel")]
        public Union<string, IntrinsicFunction> NestingLevel { get; set; }

    }
}
