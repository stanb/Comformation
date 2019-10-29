using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member ApprovalThresholdPolicy
    /// A policy type that defines the voting rules for the network. The rules decide if a proposal is approved.
    /// Approval may be based on criteria such as the percentage of YES votes and the duration of the proposal. The
    /// policy applies to all proposals and is specified when the network is created.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html
    /// </summary>
    public class ApprovalThresholdPolicy
    {

        /// <summary>
        /// ThresholdComparator
        /// Determines whether the vote percentage must be greater than the ThresholdPercentage or must be
        /// greater than or equal to the ThreholdPercentage to be approved.
        /// Required: No
        /// Type: String
        /// Allowed Values: GREATER_THAN | GREATER_THAN_OR_EQUAL_TO
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThresholdComparator")]
        public Union<string, IntrinsicFunction> ThresholdComparator { get; set; }

        /// <summary>
        /// ThresholdPercentage
        /// The percentage of votes among all members that must be YES for a proposal to be approved. For
        /// example, a ThresholdPercentage value of 50 indicates 50%. The ThresholdComparator determines the
        /// precise comparison. If a ThresholdPercentage value of 50 is specified on a network with 10 members,
        /// along with a ThresholdComparator value of GREATER_THAN, this indicates that 6 YES votes are required
        /// for the proposal to be approved.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThresholdPercentage")]
        public Union<int, IntrinsicFunction> ThresholdPercentage { get; set; }

        /// <summary>
        /// ProposalDurationInHours
        /// The duration from the time that a proposal is created until it expires. If members cast neither the
        /// required number of YES votes to approve the proposal nor the number of NO votes required to reject
        /// it before the duration expires, the proposal is EXPIRED and ProposalActions are not carried out.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 168
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProposalDurationInHours")]
        public Union<int, IntrinsicFunction> ProposalDurationInHours { get; set; }

    }
}
