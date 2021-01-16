using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ObjectLockRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockrule.html
    /// </summary>
    public class ObjectLockRule
    {

        /// <summary>
        /// DefaultRetention
        /// The default retention period that you want to apply to new objects placed in the specified bucket.
        /// Bucket default settings require both a mode and a period.
        /// Required: No
        /// Type: DefaultRetention
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultRetention")]
        public DefaultRetention DefaultRetention { get; set; }

    }
}
