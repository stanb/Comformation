using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment UpdateError
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-updateerror.html
    /// </summary>
    public class UpdateError
    {

        /// <summary>
        /// ErrorCode
        /// The code for the error with the update.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorCode")]
        public Union<string, IntrinsicFunction> ErrorCode { get; set; }

        /// <summary>
        /// ErrorMessage
        /// The error message associated with the update error.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public Union<string, IntrinsicFunction> ErrorMessage { get; set; }

    }
}
