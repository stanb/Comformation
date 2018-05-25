using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Member
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html
    /// </summary>
    public class MemberResource : ResourceBase
    {
        public class MemberProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html#cfn-guardduty-member-status
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html#cfn-guardduty-member-memberid
            /// </summary>
			public Union<string, IntrinsicFunction> MemberId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html#cfn-guardduty-member-email
            /// </summary>
			public Union<string, IntrinsicFunction> Email { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html#cfn-guardduty-member-message
            /// </summary>
			public Union<string, IntrinsicFunction> Message { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html#cfn-guardduty-member-disableemailnotification
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableEmailNotification { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-member.html#cfn-guardduty-member-detectorid
            /// </summary>
			public Union<string, IntrinsicFunction> DetectorId { get; set; }

        }
    
        public string Type { get; } = "AWS::GuardDuty::Member";
        
        public MemberProperties Properties { get; } = new MemberProperties();
    }
}
