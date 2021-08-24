using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Project
{
    /// <summary>
    /// AWS::DataBrew::Project Sample
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-project-sample.html
    /// </summary>
    public class Sample
    {

        /// <summary>
        /// Size
        /// The number of rows in the sample.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 5000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

        /// <summary>
        /// Type
        /// The way in which DataBrew obtains rows from a dataset.
        /// Required: Yes
        /// Type: String
        /// Allowed values: FIRST_N | LAST_N | RANDOM
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
