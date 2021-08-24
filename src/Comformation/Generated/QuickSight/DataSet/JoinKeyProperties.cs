using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet JoinKeyProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joinkeyproperties.html
    /// </summary>
    public class JoinKeyProperties
    {

        /// <summary>
        /// UniqueKey
        /// A value that indicates that a row in a table is uniquely identified by the columns in a join key.
        /// This is used by Amazon QuickSightto optimize query performance.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UniqueKey")]
        public Union<bool, IntrinsicFunction> UniqueKey { get; set; }

    }
}
