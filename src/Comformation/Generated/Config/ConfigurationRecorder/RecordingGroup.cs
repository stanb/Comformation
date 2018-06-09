using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationRecorder
{
    /// <summary>
    /// AWS Config ConfigurationRecorder RecordingGroup
    /// RecordingGroup is property of the AWS::Config::ConfigurationRecorder resource that defines which AWS resource
    /// types to include in a recording group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html
    /// </summary>
    public class RecordingGroup
    {

        /// <summary>
        /// AllSupported
        /// Indicates whether to record all supported resource types. If you specify this property, do not
        /// specify the ResourceTypes property.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("AllSupported")]
        public Union<bool, IntrinsicFunction> AllSupported { get; set; }

        /// <summary>
        /// IncludeGlobalResourceTypes
        /// Indicates whether AWS Config records all supported global resource types. When AWS Config supports
        /// new global resource types, AWS Config will automatically start recording them if you enable this
        /// property.
        /// Note If you set this property to true, you must set the AllSupported property to true.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("IncludeGlobalResourceTypes")]
        public Union<bool, IntrinsicFunction> IncludeGlobalResourceTypes { get; set; }

        /// <summary>
        /// ResourceTypes
        /// A list of valid AWS resource types to include in this recording group, such as AWS::EC2::Instance or
        /// AWS::CloudTrail::Trail. If you specify this property, do not specify the AllSupported property. For
        /// a list of supported resource types, see Supported resource types in the AWS Config Developer Guide.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public Union<List<string>, IntrinsicFunction> ResourceTypes { get; set; }

    }
}
