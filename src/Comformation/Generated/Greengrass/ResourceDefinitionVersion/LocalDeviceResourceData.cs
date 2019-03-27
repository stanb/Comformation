using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS IoT Greengrass ResourceDefinitionVersion LocalDeviceResourceData
    /// Settings for a 		local device resource, which represents a file under /dev. 		 For more information, see
    /// Access Local Resources with Lambda Functions in the AWS IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localdeviceresourcedata.html
    /// </summary>
    public class LocalDeviceResourceData
    {

        /// <summary>
        /// SourcePath
        /// The local absolute path of the device resource. The source path for a device resource can refer 				
        /// only to a character device or block device under /dev.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

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
