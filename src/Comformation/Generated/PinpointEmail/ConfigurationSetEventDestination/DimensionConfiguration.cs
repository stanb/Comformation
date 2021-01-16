using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination DimensionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-dimensionconfiguration.html
    /// </summary>
    public class DimensionConfiguration
    {

        /// <summary>
        /// DimensionValueSource
        /// The location where Amazon Pinpoint finds the value of a dimension to publish to Amazon CloudWatch.
        /// Acceptable values: MESSAGE_TAG, EMAIL_HEADER, and LINK_TAG.
        /// If you want Amazon Pinpoint to use the message tags that you specify using an X-SES-MESSAGE-TAGS
        /// header or a parameter to the SendEmail API, choose MESSAGE_TAG. If you want Amazon Pinpoint to use
        /// your own email headers, choose EMAIL_HEADER. If you want Amazon Pinpoint to use tags that are
        /// specified in your links, choose LINK_TAG.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionValueSource")]
        public Union<string, IntrinsicFunction> DimensionValueSource { get; set; }

        /// <summary>
        /// DefaultDimensionValue
        /// The default value of the dimension that is published to Amazon CloudWatch if you don&#39;t provide the
        /// value of the dimension when you send an email. This value has to meet the following criteria:
        /// It can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). It can
        /// contain no more than 256 characters.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultDimensionValue")]
        public Union<string, IntrinsicFunction> DefaultDimensionValue { get; set; }

        /// <summary>
        /// DimensionName
        /// The name of an Amazon CloudWatch dimension associated with an email sending metric. The name has to
        /// meet the following criteria:
        /// It can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-). It can
        /// contain no more than 256 characters.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionName")]
        public Union<string, IntrinsicFunction> DimensionName { get; set; }

    }
}
