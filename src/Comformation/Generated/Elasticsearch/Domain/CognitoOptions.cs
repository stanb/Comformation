using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain CognitoOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-cognitooptions.html
    /// </summary>
    public class CognitoOptions
    {

        /// <summary>
        /// Enabled
        /// Whether to enable or disable Amazon Cognito authentication for Kibana. See Amazon Cognito
        /// Authentication for Kibana.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// IdentityPoolId
        /// The Amazon Cognito identity pool ID that you want Amazon ES to use for Kibana authentication.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IdentityPoolId")]
        public Union<string, IntrinsicFunction> IdentityPoolId { get; set; }

        /// <summary>
        /// RoleArn
        /// The AmazonESCognitoAccess role that allows Amazon ES to configure your user pool and identity pool.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// UserPoolId
        /// The Amazon Cognito user pool ID that you want Amazon ES to use for Kibana authentication.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserPoolId")]
        public Union<string, IntrinsicFunction> UserPoolId { get; set; }

    }
}
