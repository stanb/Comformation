using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS::Config::ConfigRule SourceDetail
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source-sourcedetails.html
    /// </summary>
    public class SourceDetail
    {

        /// <summary>
        /// EventSource
        /// 		
        /// The source of the event, such as an AWS service, that triggers 			AWS Config to evaluate your AWS
        /// resources.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: aws. config
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventSource")]
        public Union<string, IntrinsicFunction> EventSource { get; set; }

        /// <summary>
        /// MaximumExecutionFrequency
        /// 		
        /// The frequency at which you want AWS Config to run evaluations 			for a custom rule with a periodic
        /// trigger. If you specify a value 			for MaximumExecutionFrequency, then 				MessageType must use the
        /// 				ScheduledNotification value.
        /// 		 		
        /// Note By default, rules with a periodic trigger are evaluated 				every 24 hours. To change the
        /// frequency, specify a valid value 				for the MaximumExecutionFrequency 				parameter. Based on the
        /// valid value you choose, AWS Config runs 				evaluations once for each valid value. For example, if
        /// you 				choose Three_Hours, AWS Config runs evaluations 				once every three hours. In this case,
        /// Three_Hours 				is the frequency of this rule.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: One_Hour | Six_Hours | Three_Hours | Twelve_Hours | TwentyFour_Hours
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumExecutionFrequency")]
        public Union<string, IntrinsicFunction> MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// MessageType
        /// 		
        /// The type of notification that triggers AWS Config to run an 			evaluation for a rule. You can
        /// specify the following notification 			types:
        /// 		
        /// 			 			 			 			 		 				 					 ConfigurationItemChangeNotification - Triggers 					an evaluation when
        /// AWS Config delivers a configuration item 					as a result of a resource change. 			 				
        /// OversizedConfigurationItemChangeNotification 					- Triggers an evaluation when AWS Config delivers
        /// an 					oversized configuration item. AWS Config may generate this 					notification type when a
        /// resource changes and the 					notification exceeds the maximum size allowed by Amazon 					SNS. 			
        /// 				 ScheduledNotification - Triggers a 					periodic evaluation at the frequency specified for
        /// 						MaximumExecutionFrequency. 			 				 ConfigurationSnapshotDeliveryCompleted - 					Triggers a
        /// periodic evaluation when AWS Config delivers a 					configuration snapshot. 			
        /// 		
        /// If you want your custom rule to be triggered by configuration 			changes, specify two SourceDetail
        /// objects, one for 				ConfigurationItemChangeNotification and one for
        /// 				OversizedConfigurationItemChangeNotification.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: ConfigurationItemChangeNotification | ConfigurationSnapshotDeliveryCompleted |
        /// OversizedConfigurationItemChangeNotification | ScheduledNotification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageType")]
        public Union<string, IntrinsicFunction> MessageType { get; set; }

    }
}
