using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationRecorder
{
    /// <summary>
    /// AWS::Config::ConfigurationRecorder RecordingGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html
    /// </summary>
    public class RecordingGroup
    {

        /// <summary>
        /// AllSupported
        /// 		
        /// Specifies whether AWS Config records configuration changes for 			every supported type of regional
        /// resource.
        /// 		
        /// If you set this option to true, when AWS Config 			adds support for a new type of regional resource,
        /// it starts 			recording resources of that type automatically.
        /// 		
        /// If you set this option to true, you cannot 			enumerate a list of resourceTypes.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllSupported")]
        public Union<bool, IntrinsicFunction> AllSupported { get; set; }

        /// <summary>
        /// IncludeGlobalResourceTypes
        /// 		
        /// Specifies whether AWS Config includes all supported types of 			global resources (for example, IAM
        /// resources) with the resources 			that it records.
        /// 		
        /// Before you can set this option to true, you must 			set the AllSupported option to 			true.
        /// 		
        /// If you set this option to true, when AWS Config 			adds support for a new type of global resource,
        /// it starts recording 			resources of that type automatically.
        /// 		
        /// The configuration details for any global resource are the same 			in all regions. To prevent
        /// duplicate configuration items, you should 			consider customizing AWS Config in only one region to
        /// record global 			resources.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeGlobalResourceTypes")]
        public Union<bool, IntrinsicFunction> IncludeGlobalResourceTypes { get; set; }

        /// <summary>
        /// ResourceTypes
        /// A comma-separated list that specifies the types of AWS resources for which AWS Config records
        /// configuration changes (for 			example, AWS::EC2::Instance or 				AWS::CloudTrail::Trail).
        /// 		
        /// To record all configuration changes, you must 			set the AllSupported option to 			false.
        /// 		
        /// If you set this option to true, when AWS Config 			adds support for a new type of resource, it will
        /// not record 			resources of that type unless you manually add that type to your 			recording group.
        /// 		
        /// For a list of valid resourceTypes values, see the 				resourceType Value column in 				Supported AWS
        /// Resource Types.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public List<Union<string, IntrinsicFunction>> ResourceTypes { get; set; }

    }
}
