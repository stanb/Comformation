using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler SchemaChangePolicy
    /// A policy that specifies update and deletion behaviors for the crawler.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schemachangepolicy.html
    /// </summary>
    public class SchemaChangePolicy
    {

        /// <summary>
        /// UpdateBehavior
        /// The update behavior when the crawler finds a changed schema.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateBehavior")]
        public Union<string, IntrinsicFunction> UpdateBehavior { get; set; }

        /// <summary>
        /// DeleteBehavior
        /// The deletion behavior when the crawler finds a deleted object.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteBehavior")]
        public Union<string, IntrinsicFunction> DeleteBehavior { get; set; }

    }
}
