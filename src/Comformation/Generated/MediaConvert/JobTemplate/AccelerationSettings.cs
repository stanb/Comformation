using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConvert.JobTemplate
{
    /// <summary>
    /// AWS::MediaConvert::JobTemplate AccelerationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-jobtemplate-accelerationsettings.html
    /// </summary>
    public class AccelerationSettings
    {

        /// <summary>
        /// Mode
        /// Specify the conditions when the service will run your job with accelerated transcoding.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

    }
}
