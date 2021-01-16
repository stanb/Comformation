using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceAttachmentConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmentconfiguration.html
    /// </summary>
    public class ConfluenceAttachmentConfiguration
    {

        /// <summary>
        /// CrawlAttachments
        /// Indicates whether Amazon Kendra indexes attachments to the pages and blogs in the Confluence data
        /// source.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlAttachments")]
        public Union<bool, IntrinsicFunction> CrawlAttachments { get; set; }

        /// <summary>
        /// AttachmentFieldMappings
        /// Defines how attachment metadata fields should be mapped to index fields. Before you can map a field,
        /// you must first create an index field with a matching type using the console or the UpdateIndex
        /// operation.
        /// If you specify the AttachentFieldMappings parameter, you must specify at least one field mapping.
        /// Required: No
        /// Type: ConfluenceAttachmentFieldMappingsList
        /// Maximum: 11
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttachmentFieldMappings")]
        public ConfluenceAttachmentFieldMappingsList AttachmentFieldMappings { get; set; }

    }
}
