using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset FilterExpression
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filterexpression.html
    /// </summary>
    public class FilterExpression
    {

        /// <summary>
        /// Expression
        /// The expression which includes condition names followed by substitution variables, possibly grouped
        /// and combined with other conditions. For example, &quot;(starts_with :prefix1 or starts_with :prefix2) and
        /// (ends_with :suffix1 or ends_with :suffix2)&quot;. Substitution variables should start with &#39;:&#39; symbol.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// ValuesMap
        /// The map of substitution variable names to their values used in this filter expression.
        /// Required: Yes
        /// Type: List of FilterValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ValuesMap")]
        public List<FilterValue> ValuesMap { get; set; }

    }
}
