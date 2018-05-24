using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationRecorder
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html
    /// </summary>
    public class ConfigurationRecorderResource : ResourceBase
    {
        public class ConfigurationRecorderProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-recordinggroup
            /// </summary>
			public Union<RecordingGroup, IntrinsicFunction> RecordingGroup { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleARN { get; set; }

        }
    
        public string Type { get; } = "AWS::Config::ConfigurationRecorder";
        
        public ConfigurationRecorderProperties Properties { get; } = new ConfigurationRecorderProperties();
    }
}
