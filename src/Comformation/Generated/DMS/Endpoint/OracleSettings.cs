using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint OracleSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-oraclesettings.html
    /// </summary>
    public class OracleSettings
    {

        /// <summary>
        /// SecretsManagerOracleAsmAccessRoleArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretsManagerOracleAsmAccessRoleArn")]
        public Union<string, IntrinsicFunction> SecretsManagerOracleAsmAccessRoleArn { get; set; }

        /// <summary>
        /// SecretsManagerOracleAsmSecretId
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretsManagerOracleAsmSecretId")]
        public Union<string, IntrinsicFunction> SecretsManagerOracleAsmSecretId { get; set; }

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
        /// SecretsManagerAccessRoleArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretsManagerAccessRoleArn")]
        public Union<string, IntrinsicFunction> SecretsManagerAccessRoleArn { get; set; }

    }
}
