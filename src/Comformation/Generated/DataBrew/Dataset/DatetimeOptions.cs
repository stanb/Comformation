using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset DatetimeOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html
    /// </summary>
    public class DatetimeOptions
    {

        /// <summary>
        /// Format
        /// Required option, that defines the datetime format used for a date parameter in the Amazon S3 path.
        /// Should use only supported datetime specifiers and separation characters, all litera a-z or A-Z
        /// character should be escaped with single quotes. E. g. &quot;MM. dd. yyyy-&#39;at&#39;-HH:mm&quot;.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// TimezoneOffset
        /// Optional value for a timezone offset of the datetime parameter value in the Amazon S3 path.
        /// Shouldn&#39;t be used if Format for this parameter includes timezone fields. If no offset specified, UTC
        /// is assumed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimezoneOffset")]
        public Union<string, IntrinsicFunction> TimezoneOffset { get; set; }

        /// <summary>
        /// LocaleCode
        /// Optional value for a non-US locale code, needed for correct interpretation of some date formats.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LocaleCode")]
        public Union<string, IntrinsicFunction> LocaleCode { get; set; }

    }
}
