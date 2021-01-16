using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.RealtimeLogConfig
{
    /// <summary>
    /// AWS::CloudFront::RealtimeLogConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-realtimelogconfig.html
    /// </summary>
    public class RealtimeLogConfigResource : ResourceBase
    {
        public class RealtimeLogConfigProperties
        {
            /// <summary>
            /// EndPoints
            /// 		
            /// Contains information about the Amazon Kinesis data stream where you are sending real-time 			log
            /// data for this real-time log configuration.
            /// 	
            /// Required: Yes
            /// Type: List of EndPoint
            /// Update requires: No interruption
            /// </summary>
            public List<EndPoint> EndPoints { get; set; }

            /// <summary>
            /// Fields
            /// 		
            /// A list of fields that are included in each real-time log record. In an API response, the 			fields
            /// are provided in the same order in which they are sent to the Amazon Kinesis data 			stream.
            /// 		
            /// For more information about fields, see Real-time log configuration fields in the 			Amazon
            /// CloudFront Developer Guide.
            /// 	
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Fields { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The unique name of this real-time log configuration.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SamplingRate
            /// 		
            /// The sampling rate for this real-time log configuration. The sampling rate determines the
            /// 			percentage of viewer requests that are represented in the real-time log data. The 			sampling
            /// rate is an integer between 1 and 100, inclusive.
            /// 	
            /// Required: Yes
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> SamplingRate { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::RealtimeLogConfig";

        public RealtimeLogConfigProperties Properties { get; } = new RealtimeLogConfigProperties();

    }

    public static class RealtimeLogConfigAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
