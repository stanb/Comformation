using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSet
{
    /// <summary>
    /// AWS::SES::ConfigurationSet
    /// The AWS::SES::ConfigurationSet resource let syou create groups of rules that you can apply to the emails you
    /// send using Amazon SES. For more information about using configuration sets, see Using Amazon SES Configuration
    /// Sets in the Amazon Simple Email Service Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html
    /// </summary>
    public class ConfigurationSetResource : ResourceBase
    {
        public class ConfigurationSetProperties
        {
            /// <summary>
            /// Name
            /// The name of the configuration set. The name must meet the following requirements:
            /// Contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain 64
            /// characters or fewer.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::ConfigurationSet";
        
        public ConfigurationSetProperties Properties { get; } = new ConfigurationSetProperties();
    }
}
