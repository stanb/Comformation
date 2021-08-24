using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.ServiceProfile
{
    /// <summary>
    /// AWS::IoTWireless::ServiceProfile LoRaWANServiceProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-serviceprofile-lorawanserviceprofile.html
    /// </summary>
    public class LoRaWANServiceProfile
    {

        /// <summary>
        /// UlRate
        /// 		
        /// The ULRate value. The minimum value is 0 and maximum value is 2147483647.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UlRate")]
        public Union<int, IntrinsicFunction> UlRate { get; set; }

        /// <summary>
        /// UlBucketSize
        /// 		
        /// The UlBucketSize value. The minimum value is 0 and maximum value is 2147483647.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UlBucketSize")]
        public Union<int, IntrinsicFunction> UlBucketSize { get; set; }

        /// <summary>
        /// UlRatePolicy
        /// 		
        /// The ULRatePolicy value. The maximum length is 256 characters.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UlRatePolicy")]
        public Union<string, IntrinsicFunction> UlRatePolicy { get; set; }

        /// <summary>
        /// DlRate
        /// 		
        /// The DLRate value. The minimum value is 0 and maximum value is 2147483647.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DlRate")]
        public Union<int, IntrinsicFunction> DlRate { get; set; }

        /// <summary>
        /// DlBucketSize
        /// 		
        /// The DLBucketSize value. The minimum value is 0 and maximum value is 2147483647.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DlBucketSize")]
        public Union<int, IntrinsicFunction> DlBucketSize { get; set; }

        /// <summary>
        /// DlRatePolicy
        /// 		
        /// The DLRatePolicy value. Maximum length is 256 characters.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DlRatePolicy")]
        public Union<string, IntrinsicFunction> DlRatePolicy { get; set; }

        /// <summary>
        /// AddGwMetadata
        /// The AddGWMetaData value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddGwMetadata")]
        public Union<bool, IntrinsicFunction> AddGwMetadata { get; set; }

        /// <summary>
        /// DevStatusReqFreq
        /// 		
        /// The DevStatusReqFreq value.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DevStatusReqFreq")]
        public Union<int, IntrinsicFunction> DevStatusReqFreq { get; set; }

        /// <summary>
        /// ReportDevStatusBattery
        /// 		
        /// The ReportDevStatusBattery value.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReportDevStatusBattery")]
        public Union<bool, IntrinsicFunction> ReportDevStatusBattery { get; set; }

        /// <summary>
        /// ReportDevStatusMargin
        /// 		
        /// The ReportDevStatusMargin value.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReportDevStatusMargin")]
        public Union<bool, IntrinsicFunction> ReportDevStatusMargin { get; set; }

        /// <summary>
        /// DrMin
        /// 		
        /// The DRMin value. The minimum value is 0 and maximum value is 15.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrMin")]
        public Union<int, IntrinsicFunction> DrMin { get; set; }

        /// <summary>
        /// DrMax
        /// 		
        /// The DRMax value. The minimum value is 0 and maximum value is 15.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrMax")]
        public Union<int, IntrinsicFunction> DrMax { get; set; }

        /// <summary>
        /// ChannelMask
        /// 		
        /// The ChannelMask value. It has a maximum length of 2048 characters.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelMask")]
        public Union<string, IntrinsicFunction> ChannelMask { get; set; }

        /// <summary>
        /// PrAllowed
        /// 		
        /// The PRAllowed value that describes whether passive roaming is allowed.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrAllowed")]
        public Union<bool, IntrinsicFunction> PrAllowed { get; set; }

        /// <summary>
        /// HrAllowed
        /// 		
        /// The HRAllowed value that describes whether handover roaming is allowed.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HrAllowed")]
        public Union<bool, IntrinsicFunction> HrAllowed { get; set; }

        /// <summary>
        /// RaAllowed
        /// The RAAllowed value that describes whether roaming activation is allowed.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RaAllowed")]
        public Union<bool, IntrinsicFunction> RaAllowed { get; set; }

        /// <summary>
        /// NwkGeoLoc
        /// 		
        /// The NwkGeoLoc value.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkGeoLoc")]
        public Union<bool, IntrinsicFunction> NwkGeoLoc { get; set; }

        /// <summary>
        /// TargetPer
        /// 		
        /// The TargetPer value. Minimum value is 0 and maximum value is 100.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetPer")]
        public Union<int, IntrinsicFunction> TargetPer { get; set; }

        /// <summary>
        /// MinGwDiversity
        /// 		
        /// The MinGwDiversity value. The minimum value is 1 and maximum value is 100.
        /// 		
        /// This property is ReadOnly and can&#39;t be inputted for create. It&#39;s returned with Fn::GetAtt
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinGwDiversity")]
        public Union<int, IntrinsicFunction> MinGwDiversity { get; set; }

    }
}
