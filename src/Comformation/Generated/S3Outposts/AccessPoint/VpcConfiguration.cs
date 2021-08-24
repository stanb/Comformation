using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.AccessPoint
{
    /// <summary>
    /// AWS::S3Outposts::AccessPoint VpcConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-accesspoint-vpcconfiguration.html
    /// </summary>
    public class VpcConfiguration
    {

        /// <summary>
        /// VpcId
        /// The ID of the VPC configuration.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

    }
}
