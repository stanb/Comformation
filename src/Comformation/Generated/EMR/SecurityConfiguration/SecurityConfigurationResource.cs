using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.SecurityConfiguration
{
    /// <summary>
    /// AWS::EMR::SecurityConfiguration
    /// The AWS::EMR::SecurityConfiguration resource creates a security configuration that is stored in the Amazon EMR
    /// web service. You can specify the security configuration when creating a cluster. For more information, see
    /// Specifying Amazon EMR Encryption Options Using a Security Configuration in the Amazon EMR Release Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html
    /// </summary>
    public class SecurityConfigurationResource : ResourceBase
    {
        public class SecurityConfigurationProperties
        {
            /// <summary>
            /// Name
            /// The name of the security configuration. For a list of valid parameters for encryption settings, see
            /// AWS CLI Security Configuration JSON Reference in the Amazon EMR Release Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SecurityConfiguration
            /// The security configuration details in JSON format.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SecurityConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::EMR::SecurityConfiguration";
        
        public SecurityConfigurationProperties Properties { get; } = new SecurityConfigurationProperties();

    }
}
