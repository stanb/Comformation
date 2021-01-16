using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile InforNexusConnectorProfileCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-infornexusconnectorprofilecredentials.html
    /// </summary>
    public class InforNexusConnectorProfileCredentials
    {

        /// <summary>
        /// AccessKeyId
        /// The Access Key portion of the credentials.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public Union<string, IntrinsicFunction> AccessKeyId { get; set; }

        /// <summary>
        /// UserId
        /// The identifier for the user.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserId")]
        public Union<string, IntrinsicFunction> UserId { get; set; }

        /// <summary>
        /// SecretAccessKey
        /// The secret key used to sign requests.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretAccessKey")]
        public Union<string, IntrinsicFunction> SecretAccessKey { get; set; }

        /// <summary>
        /// Datakey
        /// The encryption keys used to encrypt data.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Datakey")]
        public Union<string, IntrinsicFunction> Datakey { get; set; }

    }
}
