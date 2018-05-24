using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.SecurityConfiguration
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html
    /// </summary>
    public class SecurityConfigurationResource : ResourceBase
    {
        public class SecurityConfigurationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html#cfn-emr-securityconfiguration-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html#cfn-emr-securityconfiguration-securityconfiguration
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SecurityConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::EMR::SecurityConfiguration";
        
        public SecurityConfigurationProperties Properties { get; } = new SecurityConfigurationProperties();
    }
}
