using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html
    /// </summary>
    public class SourceSelectionCriteria
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-ssekmsencryptedobjects
        /// </summary>
        [JsonProperty("SseKmsEncryptedObjects")]
        public Union<SseKmsEncryptedObjects, IntrinsicFunction> SseKmsEncryptedObjects { get; set; }

    }
}
