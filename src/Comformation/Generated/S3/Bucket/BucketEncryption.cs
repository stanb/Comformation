using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html
    /// </summary>
    public class BucketEncryption
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html#cfn-s3-bucket-bucketencryption-serversideencryptionconfiguration
        /// </summary>
        [JsonProperty("ServerSideEncryptionConfiguration")]
        public Union<List<ServerSideEncryptionRule>, IntrinsicFunction> ServerSideEncryptionConfiguration { get; set; }

    }
}
