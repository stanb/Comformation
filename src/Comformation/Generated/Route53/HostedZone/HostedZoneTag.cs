using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone HostedZoneTag
    /// A complex type that contains information about a tag that you want to add or edit for the specified health
    /// check or hosted zone.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzonetags.html
    /// </summary>
    public class HostedZoneTag
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
