using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html
    /// </summary>
    public class ConfigurationSetEventDestinationResource : ResourceBase
    {
        public class ConfigurationSetEventDestinationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html#cfn-ses-configurationseteventdestination-configurationsetname
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigurationSetName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html#cfn-ses-configurationseteventdestination-eventdestination
            /// </summary>
			public Union<EventDestination, IntrinsicFunction> EventDestination { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::ConfigurationSetEventDestination";
        
        public ConfigurationSetEventDestinationProperties Properties { get; } = new ConfigurationSetEventDestinationProperties();
    }
}
