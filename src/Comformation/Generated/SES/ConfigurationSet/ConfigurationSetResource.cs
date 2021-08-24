using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSet
{
    /// <summary>
    /// AWS::SES::ConfigurationSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html
    /// </summary>
    public class ConfigurationSetResource : ResourceBase
    {
        public class ConfigurationSetProperties
        {
            /// <summary>
            /// Name
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::SES::ConfigurationSet";

        public ConfigurationSetProperties Properties { get; } = new ConfigurationSetProperties();

    }
}
