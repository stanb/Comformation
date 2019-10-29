using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route MatchRange
    /// An object that represents the range of values to match on. The first character of the range is included in the
    /// range, though the last character is not. For example, if the range specified were 1-100, only values 1-99
    /// would be matched.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html
    /// </summary>
    public class MatchRange
    {

        /// <summary>
        /// Start
        /// The start of the range.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Start")]
        public Union<int, IntrinsicFunction> Start { get; set; }

        /// <summary>
        /// End
        /// The end of the range.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("End")]
        public Union<int, IntrinsicFunction> End { get; set; }

    }
}
