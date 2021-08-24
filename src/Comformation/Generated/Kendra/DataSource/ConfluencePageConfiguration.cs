using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluencePageConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepageconfiguration.html
    /// </summary>
    public class ConfluencePageConfiguration
    {

        /// <summary>
        /// PageFieldMappings
        /// Defines how page metadata fields should be mapped to index fields. Before you can map a field, you
        /// must first create an index field with a matching type using the console or the UpdateIndex
        /// operation.
        /// If you specify the PageFieldMappings parameter, you must specify at least one field mapping.
        /// Required: No
        /// Type: List of ConfluencePageToIndexFieldMapping
        /// Maximum: 12
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PageFieldMappings")]
        public List<ConfluencePageToIndexFieldMapping> PageFieldMappings { get; set; }

    }
}
