using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinitionVersion RunAs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-runas.html
    /// </summary>
    public class RunAs
    {

        /// <summary>
        /// Uid
        /// The user ID whose permissions are used to run the Lambda function. You can use the getent passwd
        /// 				 command on your core device to look up the user ID.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Uid")]
        public Union<int, IntrinsicFunction> Uid { get; set; }

        /// <summary>
        /// Gid
        /// The group ID whose permissions are used to run the Lambda function. You can use the getent group
        /// 				 command on your core device to look up the group ID.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Gid")]
        public Union<int, IntrinsicFunction> Gid { get; set; }

    }
}
