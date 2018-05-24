using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html
    /// </summary>
    public class ServerSideEncryptionRule
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-serversideencryptionbydefault
        /// </summary>
        [JsonProperty("ServerSideEncryptionByDefault")]
        public Union<ServerSideEncryptionByDefault, IntrinsicFunction> ServerSideEncryptionByDefault { get; set; }

    }
}
