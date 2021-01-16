using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index Search
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-search.html
    /// </summary>
    public class Search
    {

        /// <summary>
        /// Facetable
        /// Indicates that the field can be used to create search facets, a count of results for each value in
        /// the field. The default is false .
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Facetable")]
        public Union<bool, IntrinsicFunction> Facetable { get; set; }

        /// <summary>
        /// Searchable
        /// Determines whether the field is used in the search. If the Searchable field is true, you can use
        /// relevance tuning to manually tune how Amazon Kendra weights the field in the search. The default is
        /// true for string fields and false for number and date fields.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Searchable")]
        public Union<bool, IntrinsicFunction> Searchable { get; set; }

        /// <summary>
        /// Displayable
        /// Determines whether the field is returned in the query response. The default is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Displayable")]
        public Union<bool, IntrinsicFunction> Displayable { get; set; }

        /// <summary>
        /// Sortable
        /// Indicates that the field can be used to sort the search results. The default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sortable")]
        public Union<bool, IntrinsicFunction> Sortable { get; set; }

    }
}
