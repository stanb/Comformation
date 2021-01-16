using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinition
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinition GroupOwnerSetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-groupownersetting.html
    /// </summary>
    public class GroupOwnerSetting
    {

        /// <summary>
        /// AutoAddGroupOwner
        /// Indicates whether to give the privileges of the Linux group that owns the resource to the Lambda
        /// process. This gives 	 the Lambda process the file access permissions of the Linux group.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AutoAddGroupOwner")]
        public Union<bool, IntrinsicFunction> AutoAddGroupOwner { get; set; }

        /// <summary>
        /// GroupOwner
        /// The name of the Linux group whose privileges you want to add to the Lambda process. This value is
        /// ignored if 	 AutoAddGroupOwner is true.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GroupOwner")]
        public Union<string, IntrinsicFunction> GroupOwner { get; set; }

    }
}
