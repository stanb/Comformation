using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Thing
{
    /// <summary>
    /// AWS::IoT::Thing AttributePayload
    /// The AttributePayload property specifies up to three attributes for an AWS IoT as key–value pairs.
    /// AttributePayload is a property of the AWS::IoT::Thing resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thing-attributepayload.html
    /// </summary>
    public class AttributePayload
    {

        /// <summary>
        /// Attributes
        /// 		
        /// A JSON string containing up to three key-value pair in JSON format. For example:
        /// 		
        /// 			 {\&quot;attributes\&quot;:{\&quot;string1\&quot;:\&quot;string2\&quot;}} 		
        /// 	
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

    }
}
