using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration MarketoSourceProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-marketosourceproperties.html
    /// </summary>
    public class MarketoSourceProperties
    {

        /// <summary>
        /// Object
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

    }
}
