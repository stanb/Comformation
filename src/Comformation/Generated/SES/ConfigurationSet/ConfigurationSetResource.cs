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
            /// The name of the configuration set. The name must:
            /// Only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). Contain 64
            /// characters or fewer.
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
