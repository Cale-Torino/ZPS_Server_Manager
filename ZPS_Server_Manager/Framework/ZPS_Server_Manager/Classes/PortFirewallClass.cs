using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPS_Server_Manager
{
    internal class PortFirewallClass
    {
        //https://stackoverflow.com/questions/15409790/adding-an-application-firewall-rule-to-both-private-and-public-networks-via-win7

        public static void AddTCPRule(string ruleName, string tcpPort)
        {
            var policy = CreatePolicy();
            var rule = CreateRule();
            rule.Name = ruleName;
            rule.Enabled = true;
            rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            rule.Profiles = (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_ALL;
            rule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
            rule.LocalPorts = tcpPort;
            policy.Rules.Add(rule);
        }
        public static void AddUDPRule(string ruleName, string udpPort)
        {
            var policy = CreatePolicy();
            var rule = CreateRule();
            rule.Name = ruleName;
            rule.Enabled = true;
            rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            rule.Profiles = (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_ALL;
            rule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            rule.LocalPorts = udpPort;
            policy.Rules.Add(rule);
        }

        public static bool GetIsRuleActiveAsync(string ruleName)
        {
            var policy = CreatePolicy();
            var rules = policy.Rules.Cast<INetFwRule2>().Where(x => x.Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN && x.Name == ruleName);
            var profiles = rules.Select(x => (NET_FW_PROFILE_TYPE2_)x.Profiles).ToArray();
            return profiles.Any(x => x.HasFlag(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN))
                    && profiles.Any(x => x.HasFlag(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE))
                    && profiles.Any(x => x.HasFlag(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC));
        }

        private static INetFwPolicy2 CreatePolicy() => (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

        private static INetFwRule2 CreateRule() => (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
    }
}
