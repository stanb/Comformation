using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::SES::ConfigurationSetEventDestination DimensionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-dimensionconfiguration.html
    /// </summary>
    public class DimensionConfiguration
    {

        /// <summary>
        /// DimensionValueSource
        /// The place where Amazon SES finds the value of a dimension to publish to Amazon CloudWatch. To use
        /// the message tags that you specify using an X-SES-MESSAGE-TAGS header or a parameter to the
        /// SendEmail/SendRawEmail API, specify messageTag. To use your own email headers, specify emailHeader.
        /// To put a custom tag on any link included in your email, specify linkTag.
        /// Required: Yes
        /// Type: String
        /// Allowed values: emailHeader | linkTag | messageTag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionValueSource")]
        public Union<string, IntrinsicFunction> DimensionValueSource { get; set; }

        /// <summary>
        /// DefaultDimensionValue
        /// The default value of the dimension that is published to Amazon CloudWatch if you do not provide the
        /// value of the dimension when you send an email. The default value must meet the following
        /// requirements:
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain 256
        /// characters or fewer.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultDimensionValue")]
        public Union<string, IntrinsicFunction> DefaultDimensionValue { get; set; }

        /// <summary>
        /// DimensionName
        /// The name of an Amazon CloudWatch dimension associated with an email sending metric. The name must
        /// meet the following requirements:
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Contain 256
        /// characters or fewer.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionName")]
        public Union<string, IntrinsicFunction> DimensionName { get; set; }

    }
}
