using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.SubscriptionFilter
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html
    /// </summary>
    public class SubscriptionFilterResource : ResourceBase
    {
        public class SubscriptionFilterProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-destinationarn
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-filterpattern
            /// </summary>
			public Union<string, IntrinsicFunction> FilterPattern { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-loggroupname
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::SubscriptionFilter";
        
        public SubscriptionFilterProperties Properties { get; } = new SubscriptionFilterProperties();
    }
}
