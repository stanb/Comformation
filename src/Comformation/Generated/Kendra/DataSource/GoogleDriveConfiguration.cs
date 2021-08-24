using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource GoogleDriveConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html
    /// </summary>
    public class GoogleDriveConfiguration
    {

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of a AWS Secrets Managersecret that contains the credentials required
        /// to connect to Google Drive. For more information, see Using a Google Workspace Drive data source.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1284
        /// Pattern: arn:[a-z0-9-\. ]{1,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[^/].
        /// {0,1023}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// A list of regular expression patterns that apply to path on Google Drive. Items that match the
        /// pattern are included in the index from both shared drives and users&#39; My Drives. Items that don&#39;t
        /// match the pattern are excluded from the index. If an item matches both an inclusion pattern and an
        /// exclusion pattern, it is excluded from the index.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// A list of regular expression patterns that apply to the path on Google Drive. Items that match the
        /// pattern are excluded from the index from both shared drives and users&#39; My Drives. Items that don&#39;t
        /// match the pattern are included in the index. If an item matches both an exclusion pattern and an
        /// inclusion pattern, it is excluded from the index.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> ExclusionPatterns { get; set; }

        /// <summary>
        /// FieldMappings
        /// Defines mapping between a field in the Google Drive and a Amazon Kendra index field.
        /// If you are using the console, you can define index fields when creating the mapping. If you are
        /// using the API, you must first create the field using the UpdateIndex operation.
        /// Required: No
        /// Type: List of DataSourceToIndexFieldMapping
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; }

        /// <summary>
        /// ExcludeMimeTypes
        /// A list of MIME types to exclude from the index. All documents matching the specified MIME type are
        /// excluded.
        /// For a list of MIME types, see Using a Google Workspace Drive data source.
        /// Required: No
        /// Type: List of String
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeMimeTypes")]
        public List<Union<string, IntrinsicFunction>> ExcludeMimeTypes { get; set; }

        /// <summary>
        /// ExcludeUserAccounts
        /// A list of email addresses of the users. Documents owned by these users are excluded from the index.
        /// Documents shared with excluded users are indexed unless they are excluded in another way.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeUserAccounts")]
        public List<Union<string, IntrinsicFunction>> ExcludeUserAccounts { get; set; }

        /// <summary>
        /// ExcludeSharedDrives
        /// A list of identifiers or shared drives to exclude from the index. All files and folders stored on
        /// the shared drive are excluded.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeSharedDrives")]
        public List<Union<string, IntrinsicFunction>> ExcludeSharedDrives { get; set; }

    }
}
