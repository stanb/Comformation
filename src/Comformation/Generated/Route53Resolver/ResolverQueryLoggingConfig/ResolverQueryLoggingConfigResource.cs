using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverQueryLoggingConfig
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverQueryLoggingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverqueryloggingconfig.html
    /// </summary>
    public class ResolverQueryLoggingConfigResource : ResourceBase
    {
        public class ResolverQueryLoggingConfigProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the query logging configuration.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9\-_&#39; &#39;]+)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DestinationArn
            /// 		
            /// The ARN of the resource that you want Resolver to send query logs: an Amazon S3 bucket, a CloudWatch
            /// Logs log group, or 			a Kinesis Data Firehose delivery stream.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 600
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationArn { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::ResolverQueryLoggingConfig";

        public ResolverQueryLoggingConfigProperties Properties { get; } = new ResolverQueryLoggingConfigProperties();

    }

    public static class ResolverQueryLoggingConfigAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OwnerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("OwnerId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ShareStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ShareStatus");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> AssociationCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("AssociationCount");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatorRequestId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatorRequestId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
