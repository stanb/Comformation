using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS IoT Greengrass ResourceDefinitionVersion LocalVolumeResourceData
    /// Settings for a 		local volume resource, which represents a file or directory on the root file system. 		 For
    /// more information, see Access Local Resources with Lambda Functions in the AWS IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localvolumeresourcedata.html
    /// </summary>
    public class LocalVolumeResourceData
    {

        /// <summary>
        /// SourcePath
        /// The local absolute path of the volume resource on the host. The source path for a volume resource
        /// 				 type cannot start with /sys.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

        /// <summary>
        /// DestinationPath
        /// The absolute local path of the resource in the Lambda environment.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DestinationPath")]
        public Union<string, IntrinsicFunction> DestinationPath { get; set; }

        /// <summary>
        /// GroupOwnerSetting
        /// Settings that define additional 		Linux OS group permissions to give to the Lambda function process.
        /// Required: No
        /// Type: GroupOwnerSetting
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupOwnerSetting")]
        public GroupOwnerSetting GroupOwnerSetting { get; set; }

    }
}
