using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index Relevance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-relevance.html
    /// </summary>
    public class Relevance
    {

        /// <summary>
        /// Freshness
        /// Indicates that this field determines how &quot;fresh&quot; a document is. For example, if document 1 was
        /// created on November 5, and document 2 was created on October 31, document 1 is &quot;fresher&quot; than
        /// document 2. You can only set the Freshness field on one DATE type field. Only applies to DATE
        /// fields.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Freshness")]
        public Union<bool, IntrinsicFunction> Freshness { get; set; }

        /// <summary>
        /// Importance
        /// The relative importance of the field in the search. Larger numbers provide more of a boost than
        /// smaller numbers.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Importance")]
        public Union<int, IntrinsicFunction> Importance { get; set; }

        /// <summary>
        /// Duration
        /// Specifies the time period that the boost applies to. For example, to make the boost apply to
        /// documents with the field value within the last month, you would use &quot;2628000s&quot;. Once the field value
        /// is beyond the specified range, the effect of the boost drops off. The higher the importance, the
        /// faster the effect drops off. If you don&#39;t specify a value, the default is 3 months. The value of the
        /// field is a numeric string followed by the character &quot;s&quot;, for example &quot;86400s&quot; for one day, or
        /// &quot;604800s&quot; for one week.
        /// Only applies to DATE fields.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 10
        /// Pattern: [0-9]+[s]
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Duration")]
        public Union<string, IntrinsicFunction> Duration { get; set; }

        /// <summary>
        /// RankOrder
        /// Determines how values should be interpreted.
        /// When the RankOrder field is ASCENDING, higher numbers are better. For example, a document with a
        /// rating score of 10 is higher ranking than a document with a rating score of 1.
        /// When the RankOrder field is DESCENDING, lower numbers are better. For example, in a task tracking
        /// application, a priority 1 task is more important than a priority 5 task.
        /// Only applies to LONG and DOUBLE fields.
        /// Required: No
        /// Type: String
        /// Allowed values: ASCENDING | DESCENDING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RankOrder")]
        public Union<string, IntrinsicFunction> RankOrder { get; set; }

        /// <summary>
        /// ValueImportanceItems
        /// An array of key-value pairs that contains an array of values that should be given a different boost
        /// when they appear in the search result list. For example, if you are boosting query terms that match
        /// the department field in the result, query terms that match the department field are boosted in the
        /// result. You can add entries from the department field to boost documents with those values higher.
        /// For example, you can add entries to the map with names of departments. If you add &quot;HR&quot;, 5 and
        /// &quot;Legal&quot;,3 those departments are given special attention when they appear in the metadata of a
        /// document.
        /// Required: No
        /// Type: ValueImportanceItems
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ValueImportanceItems")]
        public ValueImportanceItems ValueImportanceItems { get; set; }

    }
}
