using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer AccessLoggingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html
    /// </summary>
    public class AccessLoggingPolicy
    {

        /// <summary>
        /// EmitInterval
        /// The interval for publishing the access logs. You can specify an interval of either 5 minutes or 60
        /// minutes.
        /// Default: 60 minutes
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EmitInterval")]
        public Union<int, IntrinsicFunction> EmitInterval { get; set; }

        /// <summary>
        /// Enabled
        /// Specifies whether access logs are enabled for the load balancer.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// S3BucketName
        /// The name of the Amazon S3 bucket where the access logs are stored.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

        /// <summary>
        /// S3BucketPrefix
        /// The logical hierarchy you created for your Amazon S3 bucket, for example my-bucket-prefix/prod. If
        /// the prefix is not provided, the log is placed at the root level of the bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketPrefix")]
        public Union<string, IntrinsicFunction> S3BucketPrefix { get; set; }

    }
}
