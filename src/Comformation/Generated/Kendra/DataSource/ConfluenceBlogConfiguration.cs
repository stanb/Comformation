using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceBlogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceblogconfiguration.html
    /// </summary>
    public class ConfluenceBlogConfiguration
    {

        /// <summary>
        /// BlogFieldMappings
        /// Defines how blog metadata fields should be mapped to index fields. Before you can map a field, you
        /// must first create an index field with a matching type using the console or the UpdateIndex
        /// operation.
        /// If you specify the BlogFieldMappings parameter, you must specify at least one field mapping.
        /// Required: No
        /// Type: List of ConfluenceBlogToIndexFieldMapping
        /// Maximum: 9
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlogFieldMappings")]
        public List<ConfluenceBlogToIndexFieldMapping> BlogFieldMappings { get; set; }

    }
}
