using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceStandardKnowledgeArticleTypeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardknowledgearticletypeconfiguration.html
    /// </summary>
    public class SalesforceStandardKnowledgeArticleTypeConfiguration
    {

        /// <summary>
        /// DocumentDataFieldName
        /// The name of the field that contains the document data to index.
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
        /// The name of the field that contains the document title.
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
        /// One or more objects that map fields in the knowledge article to Amazon Kendra index fields. The
        /// index field must exist before you can map a Salesforce field to it.
        /// Required: No
        /// Type: List of DataSourceToIndexFieldMapping
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; }

    }
}
