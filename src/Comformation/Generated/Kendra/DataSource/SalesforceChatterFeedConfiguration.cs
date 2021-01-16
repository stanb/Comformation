using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceChatterFeedConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcechatterfeedconfiguration.html
    /// </summary>
    public class SalesforceChatterFeedConfiguration
    {

        /// <summary>
        /// DocumentDataFieldName
        /// The name of the column in the Salesforce FeedItem table that contains the content to index.
        /// Typically this is the Body column.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_. ]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentDataFieldName")]
        public Union<string, IntrinsicFunction> DocumentDataFieldName { get; set; }

        /// <summary>
        /// DocumentTitleFieldName
        /// The name of the column in the Salesforce FeedItem table that contains the title of the document.
        /// This is typically the Title collumn.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_. ]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentTitleFieldName")]
        public Union<string, IntrinsicFunction> DocumentTitleFieldName { get; set; }

        /// <summary>
        /// FieldMappings
        /// Maps fields from a Salesforce chatter feed into Amazon Kendra index fields.
        /// Required: No
        /// Type: DataSourceToIndexFieldMappingList
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public DataSourceToIndexFieldMappingList FieldMappings { get; set; }

        /// <summary>
        /// IncludeFilterTypes
        /// Filters the documents in the feed based on status of the user. When you specify ACTIVE_USERS only
        /// documents from users who have an active account are indexed. When you specify STANDARD_USER only
        /// documents for Salesforce standard users are documented. You can specify both.
        /// Required: No
        /// Type: SalesforceChatterFeedIncludeFilterTypes
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeFilterTypes")]
        public SalesforceChatterFeedIncludeFilterTypes IncludeFilterTypes { get; set; }

    }
}
