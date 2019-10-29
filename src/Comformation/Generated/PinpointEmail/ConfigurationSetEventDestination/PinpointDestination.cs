using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination PinpointDestination
    /// An object that defines a Amazon Pinpoint destination for email events. You can use Amazon Pinpoint events to
    /// create attributes in Amazon Pinpoint projects. You can use these attributes to create segments for your
    /// campaigns.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-pinpointdestination.html
    /// </summary>
    public class PinpointDestination
    {

        /// <summary>
        /// ApplicationArn
        /// The Amazon Resource Name (ARN) of the Amazon Pinpoint project that you want to send email events to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationArn")]
        public Union<string, IntrinsicFunction> ApplicationArn { get; set; }

    }
}
