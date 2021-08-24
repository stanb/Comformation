using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceSpaceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespaceconfiguration.html
    /// </summary>
    public class ConfluenceSpaceConfiguration
    {

        /// <summary>
        /// CrawlPersonalSpaces
        /// Specifies whether Amazon Kendra should index personal spaces. Users can add restrictions to items in
        /// personal spaces. If personal spaces are indexed, queries without user context information may return
        /// restricted items from a personal space in their results. For more information, see Filtering on user
        /// context.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlPersonalSpaces")]
        public Union<bool, IntrinsicFunction> CrawlPersonalSpaces { get; set; }

        /// <summary>
        /// CrawlArchivedSpaces
        /// Specifies whether Amazon Kendra should index archived spaces.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlArchivedSpaces")]
        public Union<bool, IntrinsicFunction> CrawlArchivedSpaces { get; set; }

        /// <summary>
        /// IncludeSpaces
        /// A list of space keys for Confluence spaces. If you include a key, the blogs, documents, and
        /// attachments in the space are indexed. Spaces that aren&#39;t in the list aren&#39;t indexed. A space in the
        /// list must exist. Otherwise, Amazon Kendra logs an error when the data source is synchronized. If a
        /// space is in both the IncludeSpaces and the ExcludeSpaces list, the space is excluded.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSpaces")]
        public List<Union<string, IntrinsicFunction>> IncludeSpaces { get; set; }

        /// <summary>
        /// ExcludeSpaces
        /// A list of space keys of Confluence spaces. If you include a key, the blogs, documents, and
        /// attachments in the space are not indexed. If a space is in both the ExcludeSpaces and the
        /// IncludeSpaces list, the space is excluded.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeSpaces")]
        public List<Union<string, IntrinsicFunction>> ExcludeSpaces { get; set; }

        /// <summary>
        /// SpaceFieldMappings
        /// Defines how space metadata fields should be mapped to index fields. Before you can map a field, you
        /// must first create an index field with a matching type using the console or the UpdateIndex
        /// operation.
        /// If you specify the SpaceFieldMappings parameter, you must specify at least one field mapping.
        /// Required: No
        /// Type: List of ConfluenceSpaceToIndexFieldMapping
        /// Maximum: 4
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpaceFieldMappings")]
        public List<ConfluenceSpaceToIndexFieldMapping> SpaceFieldMappings { get; set; }

    }
}
