using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// AWS::QuickSight::Analysis AnalysisError
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-analysiserror.html
    /// </summary>
    public class AnalysisError
    {

        /// <summary>
        /// Type
        /// The type of the analysis error.
        /// Required: No
        /// Type: String
        /// Allowed values: ACCESS_DENIED | COLUMN_GEOGRAPHIC_ROLE_MISMATCH | COLUMN_REPLACEMENT_MISSING |
        /// COLUMN_TYPE_MISMATCH | DATA_SET_NOT_FOUND | INTERNAL_FAILURE | PARAMETER_NOT_FOUND |
        /// PARAMETER_TYPE_INVALID | PARAMETER_VALUE_INCOMPATIBLE | SOURCE_NOT_FOUND
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Message
        /// The message associated with the analysis error.
        /// Required: No
        /// Type: String
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Message")]
        public Union<string, IntrinsicFunction> Message { get; set; }

    }
}
