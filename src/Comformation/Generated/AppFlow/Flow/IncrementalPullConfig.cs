using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow IncrementalPullConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-incrementalpullconfig.html
    /// </summary>
    public class IncrementalPullConfig
    {

        /// <summary>
        /// DatetimeTypeFieldName
        /// A field that specifies the date time or timestamp field as the criteria to use when importing
        /// incremental records from the source.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatetimeTypeFieldName")]
        public Union<string, IntrinsicFunction> DatetimeTypeFieldName { get; set; }

    }
}
