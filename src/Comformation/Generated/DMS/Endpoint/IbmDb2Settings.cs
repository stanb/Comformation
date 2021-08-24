using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint IbmDb2Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-ibmdb2settings.html
    /// </summary>
    public class IbmDb2Settings
    {

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
