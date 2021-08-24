using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application DeployAsApplicationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-deployasapplicationconfiguration.html
    /// </summary>
    public class DeployAsApplicationConfiguration
    {

        /// <summary>
        /// S3ContentLocation
        /// The description of an Amazon S3 object that contains the Amazon Data Analytics application,
        /// including the Amazon Resource Name (ARN) of the S3 bucket, the name of the Amazon S3 object that
        /// contains the data, and the version number of the Amazon S3 object that contains the data.
        /// Required: Yes
        /// Type: S3ContentBaseLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ContentLocation")]
        public S3ContentBaseLocation S3ContentLocation { get; set; }

    }
}
