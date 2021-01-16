using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ServiceNowKnowledgeArticleConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowknowledgearticleconfiguration.html
    /// </summary>
    public class ServiceNowKnowledgeArticleConfiguration
    {

        /// <summary>
        /// CrawlAttachments
        /// Indicates whether Amazon Kendra should index attachments to knowledge articles.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlAttachments")]
        public Union<bool, IntrinsicFunction> CrawlAttachments { get; set; }

        /// <summary>
        /// IncludeAttachmentFilePatterns
        /// List of regular expressions applied to knowledge articles. Items that don&#39;t match the inclusion
        /// pattern are not indexed. The regex is applied to the field specified in the PatternTargetField.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeAttachmentFilePatterns")]
        public DataSourceInclusionsExclusionsStrings IncludeAttachmentFilePatterns { get; set; }

        /// <summary>
        /// ExcludeAttachmentFilePatterns
        /// List of regular expressions applied to knowledge articles. Items that don&#39;t match the inclusion
        /// pattern are not indexed. The regex is applied to the field specified in the PatternTargetField
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeAttachmentFilePatterns")]
        public DataSourceInclusionsExclusionsStrings ExcludeAttachmentFilePatterns { get; set; }

        /// <summary>
        /// DocumentDataFieldName
        /// The name of the ServiceNow field that is mapped to the index document contents field in the Amazon
        /// Kendra index.
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
        /// The name of the ServiceNow field that is mapped to the index document title field.
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
        /// Mapping between ServiceNow fields and Amazon Kendra index fields. You must create the index field
        /// before you map the field.
        /// Required: No
        /// Type: DataSourceToIndexFieldMappingList
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public DataSourceToIndexFieldMappingList FieldMappings { get; set; }

    }
}
