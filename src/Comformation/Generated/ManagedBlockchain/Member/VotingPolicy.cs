using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ManagedBlockchain.Member
{
    /// <summary>
    /// AWS::ManagedBlockchain::Member VotingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-votingpolicy.html
    /// </summary>
    public class VotingPolicy
    {

        /// <summary>
        /// ApprovalThresholdPolicy
        /// Defines the rules for the network for voting on proposals, such as the percentage of YES votes
        /// required for the proposal to be approved and the duration of the proposal. The policy applies to all
        /// proposals and is specified when the network is created.
        /// Required: No
        /// Type: ApprovalThresholdPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApprovalThresholdPolicy")]
        public ApprovalThresholdPolicy ApprovalThresholdPolicy { get; set; }

    }
}
