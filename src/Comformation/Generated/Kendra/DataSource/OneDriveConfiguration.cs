using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource OneDriveConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveconfiguration.html
    /// </summary>
    public class OneDriveConfiguration
    {

        /// <summary>
        /// TenantDomain
        /// The Azure Active Directory domain of the organization.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^([a-zA-Z0-9]+(-[a-zA-Z0-9]+)*\. )+[a-z]{2,}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TenantDomain")]
        public Union<string, IntrinsicFunction> TenantDomain { get; set; }

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of an AWS Secrets Manager secret that contains the user name and
        /// password to connect to OneDrive. The user named should be the application ID for the OneDrive
        /// application, and the password is the application key for the OneDrive application.
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
        /// OneDriveUsers
        /// A list of user accounts whose documents should be indexed.
        /// Required: Yes
        /// Type: OneDriveUsers
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OneDriveUsers")]
        public OneDriveUsers OneDriveUsers { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// A list of regular expression patterns. Documents that match the pattern are included in the index.
        /// Documents that don&#39;t match the pattern are excluded from the index. If a document matches both an
        /// inclusion pattern and an exclusion pattern, the document is not included in the index.
        /// The exclusion pattern is applied to the file name.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public DataSourceInclusionsExclusionsStrings InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// List of regular expressions applied to documents. Items that match the exclusion pattern are not
        /// indexed. If you provide both an inclusion pattern and an exclusion pattern, any item that matches
        /// the exclusion pattern isn&#39;t indexed.
        /// The exclusion pattern is applied to the file name.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public DataSourceInclusionsExclusionsStrings ExclusionPatterns { get; set; }

        /// <summary>
        /// FieldMappings
        /// A list of DataSourceToIndexFieldMapping objects that map Microsoft OneDrive fields to custom fields
        /// in the Amazon Kendra index. You must first create the index fields before you map OneDrive fields.
        /// Required: No
        /// Type: DataSourceToIndexFieldMappingList
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public DataSourceToIndexFieldMappingList FieldMappings { get; set; }

        /// <summary>
        /// DisableLocalGroups
        /// A Boolean value that specifies whether local groups are disabled (True) or enabled (False).
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableLocalGroups")]
        public Union<bool, IntrinsicFunction> DisableLocalGroups { get; set; }

    }
}
