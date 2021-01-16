using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.KeySigningKey
{
    /// <summary>
    /// AWS::Route53::KeySigningKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-keysigningkey.html
    /// </summary>
    public class KeySigningKeyResource : ResourceBase
    {
        public class KeySigningKeyProperties
        {
            /// <summary>
            /// HostedZoneId
            /// The unique string (ID) that is used to identify a hosted zone. For example: Z00001111A1ABCaaABC11.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

            /// <summary>
            /// Status
            /// 		
            /// A string that represents the current key-signing key (KSK) status.
            /// 		
            /// Status can have one of the following values:
            /// 		
            /// 			 			 			 			 			 		 				 ACTIVE 				 The KSK is being used for signing. 			 				 INACTIVE 				
            /// The KSK is not being used for signing. 			 				 DELETING 				 The KSK is in the process of being
            /// deleted. 			 				 ACTION_NEEDED 				 There is a problem with the KSK that requires you to take
            /// action to resolve. 				For example, the customer managed customer master key (CMK) might have been
            /// deleted, or the 				permissions for the customer managed CMK might have been changed. 			 				
            /// INTERNAL_FAILURE 				 There was an error during a request. Before you can continue to work with
            /// DNSSEC 					signing, including actions that involve this KSK, you must correct the problem. For
            /// example, 					you may need to activate or deactivate the KSK. 			
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 5
            /// Maximum: 150
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// A string used to identify a key-signing key (KSK). Name can include numbers, letters, periods (. ),
            /// 			hyphens (-), or underscores (_). Name must be unique for each key-signing key in the same
            /// 			hosted zone.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// KeyManagementServiceArn
            /// The Amazon resource name (ARN) for a customer managed customer master key (CMK) in AWS Key
            /// Management Service (AWS KMS). The KeyManagementServiceArn must be unique for each key-signing key
            /// (KSK) in a single hosted zone. For example:
            /// arn:aws:kms:us-east-1:111122223333:key/111a2222-a11b-1ab1-2ab2-1ab21a2b3a111.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyManagementServiceArn { get; set; }

        }

        public string Type { get; } = "AWS::Route53::KeySigningKey";

        public KeySigningKeyProperties Properties { get; } = new KeySigningKeyProperties();

    }
}
