using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index DocumentMetadataConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-documentmetadataconfiguration.html
    /// </summary>
    public class DocumentMetadataConfiguration
    {

        /// <summary>
        /// Name
        /// The name of the index field.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// The data type of the index field.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DATE_VALUE | LONG_VALUE | STRING_LIST_VALUE | STRING_VALUE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Relevance
        /// Provides manual tuning parameters to determine how the field affects the search results.
        /// Required: No
        /// Type: Relevance
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Relevance")]
        public Relevance Relevance { get; set; }

        /// <summary>
        /// Search
        /// Provides information about how the field is used during a search.
        /// Required: No
        /// Type: Search
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Search")]
        public Search Search { get; set; }

    }
}
