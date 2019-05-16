using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ApplicationVersion
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ApplicationVersion SourceBundle
    /// The SourceBundle property is an embedded property of the AWS::ElasticBeanstalk::ApplicationVersion resource.
    /// It specifies the Amazon S3 location of the source bundle for an AWS Elastic Beanstalk application version.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-sourcebundle.html
    /// </summary>
    public class SourceBundle
    {

        /// <summary>
        /// S3Bucket
        /// The Amazon S3 bucket where the data is located.
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The Amazon S3 key where the data is located.
        /// Required: Yes
        /// Type: String
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

    }
}
