using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// AWS::QuickSight::Analysis Sheet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-sheet.html
    /// </summary>
    public class Sheet
    {

        /// <summary>
        /// SheetId
        /// The unique identifier associated with a sheet.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: [\w\-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SheetId")]
        public Union<string, IntrinsicFunction> SheetId { get; set; }

        /// <summary>
        /// Name
        /// The name of a sheet. This name is displayed on the sheet&#39;s tab in the QuickSight console.
        /// Required: No
        /// Type: String
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
