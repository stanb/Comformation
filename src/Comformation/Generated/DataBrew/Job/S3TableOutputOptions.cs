using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job S3TableOutputOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3tableoutputoptions.html
    /// </summary>
    public class S3TableOutputOptions
    {

        /// <summary>
        /// Location
        /// Represents an Amazon S3 location (bucket name and object key) where DataBrew can write output from a
        /// job.
        /// Required: Yes
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public S3Location Location { get; set; }

    }
}
