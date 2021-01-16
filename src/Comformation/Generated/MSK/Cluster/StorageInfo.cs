using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster StorageInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-storageinfo.html
    /// </summary>
    public class StorageInfo
    {

        /// <summary>
        /// EBSStorageInfo
        /// EBS volume information.
        /// Required: No
        /// Type: EBSStorageInfo
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EBSStorageInfo")]
        public EBSStorageInfo EBSStorageInfo { get; set; }

    }
}
