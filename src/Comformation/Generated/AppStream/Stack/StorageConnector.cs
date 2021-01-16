using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// AWS::AppStream::Stack StorageConnector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html
    /// </summary>
    public class StorageConnector
    {

        /// <summary>
        /// Domains
        /// The names of the domains for the account.
        /// Required: No
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Domains")]
        public List<Union<string, IntrinsicFunction>> Domains { get; set; }

        /// <summary>
        /// ResourceIdentifier
        /// The ARN of the storage connector.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceIdentifier")]
        public Union<string, IntrinsicFunction> ResourceIdentifier { get; set; }

        /// <summary>
        /// ConnectorType
        /// The type of storage connector.
        /// Required: Yes
        /// Type: String
        /// Allowed values: GOOGLE_DRIVE | HOMEFOLDERS | ONE_DRIVE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorType")]
        public Union<string, IntrinsicFunction> ConnectorType { get; set; }

    }
}
