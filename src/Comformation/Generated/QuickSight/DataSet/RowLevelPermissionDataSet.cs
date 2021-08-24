using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet RowLevelPermissionDataSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-rowlevelpermissiondataset.html
    /// </summary>
    public class RowLevelPermissionDataSet
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the dataset that contains permissions for RLS.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// Namespace
        /// The namespace associated with the dataset that contains permissions for RLS.
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Pattern: ^[a-zA-Z0-9. _-]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// PermissionPolicy
        /// The type of permissions to use when interpretting the permissions for RLS. DENY_ACCESS is included
        /// for backward compatibility only.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DENY_ACCESS | GRANT_ACCESS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PermissionPolicy")]
        public Union<string, IntrinsicFunction> PermissionPolicy { get; set; }

        /// <summary>
        /// FormatVersion
        /// The user or group rules associated with the dataset that contains permissions for RLS.
        /// By default, FormatVersion is VERSION_1. When FormatVersion is VERSION_1, UserName and GroupName are
        /// required. When FormatVersion is VERSION_2, UserARN and GroupARN are required, and Namespace must not
        /// exist.
        /// Required: No
        /// Type: String
        /// Allowed values: VERSION_1 | VERSION_2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FormatVersion")]
        public Union<string, IntrinsicFunction> FormatVersion { get; set; }

    }
}
