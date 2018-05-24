using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationRecorder
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html
    /// </summary>
    public class RecordingGroup
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-allsupported
        /// </summary>
        [JsonProperty("AllSupported")]
        public Union<bool?, IntrinsicFunction> AllSupported { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-includeglobalresourcetypes
        /// </summary>
        [JsonProperty("IncludeGlobalResourceTypes")]
        public Union<bool?, IntrinsicFunction> IncludeGlobalResourceTypes { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-resourcetypes
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public Union<List<string>, IntrinsicFunction> ResourceTypes { get; set; }

    }
}
