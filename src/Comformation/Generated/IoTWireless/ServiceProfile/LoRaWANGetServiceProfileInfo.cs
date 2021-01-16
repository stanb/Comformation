using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.ServiceProfile
{
    /// <summary>
    /// AWS::IoTWireless::ServiceProfile LoRaWANGetServiceProfileInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-serviceprofile-lorawangetserviceprofileinfo.html
    /// </summary>
    public class LoRaWANGetServiceProfileInfo
    {

        /// <summary>
        /// UlRate
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UlRate")]
        public Union<int, IntrinsicFunction> UlRate { get; set; }

        /// <summary>
        /// UlBucketSize
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UlBucketSize")]
        public Union<int, IntrinsicFunction> UlBucketSize { get; set; }

        /// <summary>
        /// UlRatePolicy
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UlRatePolicy")]
        public Union<string, IntrinsicFunction> UlRatePolicy { get; set; }

        /// <summary>
        /// DlRate
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DlRate")]
        public Union<int, IntrinsicFunction> DlRate { get; set; }

        /// <summary>
        /// DlBucketSize
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DlBucketSize")]
        public Union<int, IntrinsicFunction> DlBucketSize { get; set; }

        /// <summary>
        /// DlRatePolicy
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DlRatePolicy")]
        public Union<string, IntrinsicFunction> DlRatePolicy { get; set; }

        /// <summary>
        /// AddGwMetadata
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddGwMetadata")]
        public Union<bool, IntrinsicFunction> AddGwMetadata { get; set; }

        /// <summary>
        /// DevStatusReqFreq
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DevStatusReqFreq")]
        public Union<int, IntrinsicFunction> DevStatusReqFreq { get; set; }

        /// <summary>
        /// ReportDevStatusBattery
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReportDevStatusBattery")]
        public Union<bool, IntrinsicFunction> ReportDevStatusBattery { get; set; }

        /// <summary>
        /// ReportDevStatusMargin
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReportDevStatusMargin")]
        public Union<bool, IntrinsicFunction> ReportDevStatusMargin { get; set; }

        /// <summary>
        /// DrMin
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrMin")]
        public Union<int, IntrinsicFunction> DrMin { get; set; }

        /// <summary>
        /// DrMax
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrMax")]
        public Union<int, IntrinsicFunction> DrMax { get; set; }

        /// <summary>
        /// ChannelMask
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelMask")]
        public Union<string, IntrinsicFunction> ChannelMask { get; set; }

        /// <summary>
        /// PrAllowed
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrAllowed")]
        public Union<bool, IntrinsicFunction> PrAllowed { get; set; }

        /// <summary>
        /// HrAllowed
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HrAllowed")]
        public Union<bool, IntrinsicFunction> HrAllowed { get; set; }

        /// <summary>
        /// RaAllowed
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RaAllowed")]
        public Union<bool, IntrinsicFunction> RaAllowed { get; set; }

        /// <summary>
        /// NwkGeoLoc
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkGeoLoc")]
        public Union<bool, IntrinsicFunction> NwkGeoLoc { get; set; }

        /// <summary>
        /// TargetPer
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetPer")]
        public Union<int, IntrinsicFunction> TargetPer { get; set; }

        /// <summary>
        /// MinGwDiversity
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinGwDiversity")]
        public Union<int, IntrinsicFunction> MinGwDiversity { get; set; }

    }
}
