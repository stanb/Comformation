using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration IncrementalPullConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-incrementalpullconfig.html
    /// </summary>
    public class IncrementalPullConfig
    {

        /// <summary>
        /// DatetimeTypeFieldName
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatetimeTypeFieldName")]
        public Union<string, IntrinsicFunction> DatetimeTypeFieldName { get; set; }

    }
}
