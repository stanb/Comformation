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
        /// The default Object Lock retention mode and period that you want to apply to new objects placed in
        /// the specified bucket. If Object Lock is turned on, bucket settings require both Mode and a period of
        /// either Days or Years. You cannot specify Days and Years at the same time. For more information about
        /// allowable values for mode and period, see DefaultRetention.
        /// Required: Conditional
        /// Type: DefaultRetention
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultRetention")]
        public DefaultRetention DefaultRetention { get; set; }

    }
}
