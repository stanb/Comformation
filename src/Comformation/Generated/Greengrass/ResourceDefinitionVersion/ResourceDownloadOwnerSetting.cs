using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinitionVersion ResourceDownloadOwnerSetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedownloadownersetting.html
    /// </summary>
    public class ResourceDownloadOwnerSetting
    {

        /// <summary>
        /// GroupOwner
        /// The group owner of the machine learning resource. This is the group ID (GID) of an existing Linux OS
        /// group on the system. The group&#39;s permissions are added to the Lambda process.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupOwner")]
        public Union<string, IntrinsicFunction> GroupOwner { get; set; }

        /// <summary>
        /// GroupPermission
        /// The permissions that the group owner has to the machine learning resource. Valid values are rw
        /// (read-write) or ro (read-only).
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupPermission")]
        public Union<string, IntrinsicFunction> GroupPermission { get; set; }

    }
}
