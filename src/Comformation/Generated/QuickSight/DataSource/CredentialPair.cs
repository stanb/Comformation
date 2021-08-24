using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource CredentialPair
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-credentialpair.html
    /// </summary>
    public class CredentialPair
    {

        /// <summary>
        /// AlternateDataSourceParameters
        /// A set of alternate data source parameters that you want to share for these credentials. The
        /// credentials are applied in tandem with the data source parameters when you copy a data source by
        /// using a create or update request. The API operation compares the DataSourceParameters structure
        /// that&#39;s in the request with the structures in the AlternateDataSourceParameters allow list. If the
        /// structures are an exact match, the request is allowed to use the new data source with the existing
        /// credentials. If the AlternateDataSourceParameters list is null, the DataSourceParameters originally
        /// used with these Credentials is automatically allowed.
        /// Required: No
        /// Type: List of DataSourceParameters
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlternateDataSourceParameters")]
        public List<DataSourceParameters> AlternateDataSourceParameters { get; set; }

        /// <summary>
        /// Username
        /// User name.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// Password
        /// Password.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

    }
}
