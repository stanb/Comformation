using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSO.InstanceAccessControlAttributeConfiguration
{
    /// <summary>
    /// AWS::SSO::InstanceAccessControlAttributeConfiguration AccessControlAttributeValueSourceList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributevaluesourcelist.html
    /// </summary>
    public class AccessControlAttributeValueSourceList
    {

        /// <summary>
        /// AccessControlAttributeValueSourceList_
        /// </summary>
        [JsonProperty("AccessControlAttributeValueSourceList")]
        public List<Union<string, IntrinsicFunction>> AccessControlAttributeValueSourceList_ { get; set; }

    }
}
