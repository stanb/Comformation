using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource DataSourceCredentials
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourcecredentials.html
    /// </summary>
    public class DataSourceCredentials
    {

        /// <summary>
        /// CopySourceArn
        /// The Amazon Resource Name (ARN) of a data source that has the credential pair that you want to use.
        /// When CopySourceArn is not null, the credential pair from the data source in the ARN is used as the
        /// credentials for the DataSourceCredentials structure.
        /// Required: No
        /// Type: String
        /// Pattern: ^arn:[-a-z0-9]*:quicksight:[-a-z0-9]*:[0-9]{12}:datasource/. +
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CopySourceArn")]
        public Union<string, IntrinsicFunction> CopySourceArn { get; set; }

        /// <summary>
        /// CredentialPair
        /// Credential pair. For more information, see CredentialPair.
        /// Required: No
        /// Type: CredentialPair
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CredentialPair")]
        public CredentialPair CredentialPair { get; set; }

    }
}
