using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment LastUpdate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-lastupdate.html
    /// </summary>
    public class LastUpdate
    {

        /// <summary>
        /// Status
        /// Status of last update of SUCCESS, FAILED, CREATING, DELETING.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// CreatedAt
        /// Time that last update occurred.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreatedAt")]
        public Union<string, IntrinsicFunction> CreatedAt { get; set; }

        /// <summary>
        /// Error
        /// Error string of last update, if applicable.
        /// Required: No
        /// Type: UpdateError
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Error")]
        public UpdateError Error { get; set; }

    }
}
