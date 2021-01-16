using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions ColumnWildcard
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-columnwildcard.html
    /// </summary>
    public class ColumnWildcard
    {

        /// <summary>
        /// ExcludedColumnNames
        /// Excludes column names. Any column with this name will be excluded.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludedColumnNames")]
        public List<Union<string, IntrinsicFunction>> ExcludedColumnNames { get; set; }

    }
}
