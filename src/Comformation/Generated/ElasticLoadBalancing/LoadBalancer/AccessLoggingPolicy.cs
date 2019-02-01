using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing V1 AccessLoggingPolicy
    /// The AccessLoggingPolicy property describes where and how access logs are stored for the
    /// AWS::ElasticLoadBalancing::LoadBalancer resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html
    /// </summary>
    public class AccessLoggingPolicy
    {

        /// <summary>
        /// EmitInterval
        /// The interval for publishing access logs in minutes. You can specify an interval of either 5 minutes
        /// or 60 minutes.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("EmitInterval")]
        public Union<int, IntrinsicFunction> EmitInterval { get; set; }

        /// <summary>
        /// Enabled
        /// Whether logging is enabled for the load balancer.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// S3BucketName
        /// The name of an Amazon S3 bucket where access log files are stored.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

        /// <summary>
        /// S3BucketPrefix
        /// A prefix for the all log object keys, such as my-load-balancer-logs/prod. If you store log files
        /// from multiple sources in a single bucket, you can use a prefix to distinguish each log file and its
        /// source.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("S3BucketPrefix")]
        public Union<string, IntrinsicFunction> S3BucketPrefix { get; set; }

    }
}
