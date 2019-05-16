using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table SSESpecification
    /// Represents the settings used to enable server-side encryption.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html
    /// </summary>
    public class SSESpecification
    {

        /// <summary>
        /// SSEEnabled
        /// Indicates whether server-side encryption is done using an AWS managed CMK or an AWS owned CMK. If
        /// enabled (true), server-side encryption type is set to KMS and an AWS managed CMK is used (AWS KMS
        /// charges apply). If disabled (false) or not specified, server-side encryption is set to AWS owned
        /// CMK.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEEnabled")]
        public Union<bool, IntrinsicFunction> SSEEnabled { get; set; }

    }
}
