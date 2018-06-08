using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// Amazon Simple Email Service ConfigurationSetEventDestination DimensionConfiguration
    /// The DimensionConfiguration property type specifies the dimension configuration to use when you publish email
    /// sending events to Amazon CloudWatch using Amazon SES.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-dimensionconfiguration.html
    /// </summary>
    public class DimensionConfiguration
    {

        /// <summary>
        /// DimensionValueSource
        /// The place where Amazon SES finds the value of a dimension to publish to CloudWatch. If you want
        /// Amazon SES to use the message tags that you specify using an X-SES-MESSAGE-TAGS header or a
        /// parameter to the SendEmail/SendRawEmailAPI, choose messageTag. If you want Amazon SES to use your
        /// own email headers, choose emailHeader.
        /// Valid values include: emailHeader, linkTag, and messageTag.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionValueSource")]
        public Union<string, IntrinsicFunction> DimensionValueSource { get; set; }

        /// <summary>
        /// DefaultDimensionValue
        /// The default value of the dimension that is published to Amazon CloudWatch if you do not provide the
        /// value of the dimension when you send an email. The default value can:
        /// Contain ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain up to 256
        /// characters.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultDimensionValue")]
        public Union<string, IntrinsicFunction> DefaultDimensionValue { get; set; }

        /// <summary>
        /// DimensionName
        /// The name of an Amazon CloudWatch dimension associated with an email sending metric. The name can:
        /// Contain ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain up to 256
        /// characters.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionName")]
        public Union<string, IntrinsicFunction> DimensionName { get; set; }

    }
}
