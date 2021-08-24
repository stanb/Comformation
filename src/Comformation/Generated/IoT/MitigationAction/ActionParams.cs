using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.MitigationAction
{
    /// <summary>
    /// AWS::IoT::MitigationAction ActionParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html
    /// </summary>
    public class ActionParams
    {

        /// <summary>
        /// AddThingsToThingGroupParams
        /// Specifies the group to which you want to add the devices.
        /// Required: No
        /// Type: AddThingsToThingGroupParams
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddThingsToThingGroupParams")]
        public AddThingsToThingGroupParams AddThingsToThingGroupParams { get; set; }

        /// <summary>
        /// EnableIoTLoggingParams
        /// Specifies the logging level and the role with permissions for logging. You cannot specify a logging
        /// level of DISABLED.
        /// Required: No
        /// Type: EnableIoTLoggingParams
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableIoTLoggingParams")]
        public EnableIoTLoggingParams EnableIoTLoggingParams { get; set; }

        /// <summary>
        /// PublishFindingToSnsParams
        /// Specifies the topic to which the finding should be published.
        /// Required: No
        /// Type: PublishFindingToSnsParams
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PublishFindingToSnsParams")]
        public PublishFindingToSnsParams PublishFindingToSnsParams { get; set; }

        /// <summary>
        /// ReplaceDefaultPolicyVersionParams
        /// Replaces the policy version with a default or blank policy. You specify the template name. Only a
        /// value of BLANK_POLICY is currently supported.
        /// Required: No
        /// Type: ReplaceDefaultPolicyVersionParams
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplaceDefaultPolicyVersionParams")]
        public ReplaceDefaultPolicyVersionParams ReplaceDefaultPolicyVersionParams { get; set; }

        /// <summary>
        /// UpdateCACertificateParams
        /// Specifies the new state for the CA certificate. Only a value of DEACTIVATE is currently supported.
        /// Required: No
        /// Type: UpdateCACertificateParams
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateCACertificateParams")]
        public UpdateCACertificateParams UpdateCACertificateParams { get; set; }

        /// <summary>
        /// UpdateDeviceCertificateParams
        /// Specifies the new state for a device certificate. Only a value of DEACTIVATE is currently supported.
        /// Required: No
        /// Type: UpdateDeviceCertificateParams
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateDeviceCertificateParams")]
        public UpdateDeviceCertificateParams UpdateDeviceCertificateParams { get; set; }

    }
}
