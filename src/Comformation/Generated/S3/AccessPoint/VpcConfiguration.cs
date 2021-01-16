using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.AccessPoint
{
    /// <summary>
    /// AWS::S3::AccessPoint VpcConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accesspoint-vpcconfiguration.html
    /// </summary>
    public class VpcConfiguration
    {

        /// <summary>
        /// VpcId
        /// If this field is specified, the access point will only allow connections from the specified VPC ID.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

    }
}
