using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS Glue Crawler SchemaChangePolicy
    /// The SchemaChangePolicy property type specifies update and delete behaviors for an AWS Glue crawler.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schemachangepolicy.html
    /// </summary>
    public class SchemaChangePolicy
    {

        /// <summary>
        /// UpdateBehavior
        /// The update behavior. Valid values are LOG or UPDATE_IN_DATABASE.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateBehavior")]
        public Union<string, IntrinsicFunction> UpdateBehavior { get; set; }

        /// <summary>
        /// DeleteBehavior
        /// The deletion behavior. Valid values are LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteBehavior")]
        public Union<string, IntrinsicFunction> DeleteBehavior { get; set; }

    }
}
