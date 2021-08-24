using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ServiceNowServiceCatalogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowservicecatalogconfiguration.html
    /// </summary>
    public class ServiceNowServiceCatalogConfiguration
    {

        /// <summary>
        /// CrawlAttachments
        /// Indicates whether Amazon Kendra should crawl attachments to the service catalog items.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlAttachments")]
        public Union<bool, IntrinsicFunction> CrawlAttachments { get; set; }

        /// <summary>
        /// IncludeAttachmentFilePatterns
        /// A list of regular expression patterns. Documents that match the patterns are included in the index.
        /// Documents that don&#39;t match the patterns are excluded from the index. If a document matches both an
        /// exclusion pattern and an inclusion pattern, the document is not included in the index.
        /// The regex is applied to the file name of the attachment.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeAttachmentFilePatterns")]
        public List<Union<string, IntrinsicFunction>> IncludeAttachmentFilePatterns { get; set; }

        /// <summary>
        /// ExcludeAttachmentFilePatterns
        /// A list of regular expression patterns. Documents that match the patterns are excluded from the
        /// index. Documents that don&#39;t match the patterns are included in the index. If a document matches both
        /// an exclusion pattern and an inclusion pattern, the document is not included in the index.
        /// The regex is applied to the file name of the attachment.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeAttachmentFilePatterns")]
        public List<Union<string, IntrinsicFunction>> ExcludeAttachmentFilePatterns { get; set; }

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
        /// Type: List of DataSourceToIndexFieldMapping
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; }

    }
}
