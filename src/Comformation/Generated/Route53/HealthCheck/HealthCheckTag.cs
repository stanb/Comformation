using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// AWS::Route53::HealthCheck HealthCheckTag
    /// The HealthCheckTag property describes one key-value pair that is associated with an AWS::Route53::HealthCheck
    /// resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthcheck-healthchecktag.html
    /// </summary>
    public class HealthCheckTag
    {

        /// <summary>
        /// Key
        /// 		
        /// The value of Key depends on the operation that you want to perform:
        /// 		
        /// 			 			 			 			 		 				 Add a tag to a health check or hosted zone: Key is the name that you want to
        /// give the new tag. 			 				 Edit a tag: Key is the name of the tag that you want to change the Value
        /// for. 			 				 Delete a key: Key is the name of the tag you want to remove. 			 				 Give a name to a
        /// health check: Edit the default Name tag. In the Amazon Route 53 console, 					the list of your
        /// health checks includes a Name column that lets you see the name that you&#39;ve 					given to each
        /// health check. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// 		
        /// The value of Value depends on the operation that you want to perform:
        /// 		
        /// 			 			 		 				 Add a tag to a health check or hosted zone: Value is the value that you want to give
        /// 					the new tag. 			 				 Edit a tag: Value is the new value that you want to assign the tag. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
