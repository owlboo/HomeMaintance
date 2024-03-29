﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HomeMaintance.Areas.Admin.Controllers
{
    public class IpRateLimitController : Controller
    {
        private readonly IpRateLimitOptions _options;
        private readonly IIpPolicyStore _ipPolicyStore;

        public IpRateLimitController(IOptions<IpRateLimitOptions> optionsAccessor, IIpPolicyStore ipPolicyStore)
        {
            _options = optionsAccessor.Value;
            _ipPolicyStore = ipPolicyStore;
        }

        [HttpGet]
        public IpRateLimitPolicies Get()
        {
            return _ipPolicyStore.Get(_options.IpPolicyPrefix);
        }

        [HttpPost]
        public void Post()
        {
            var pol = _ipPolicyStore.Get(_options.IpPolicyPrefix);

            pol.IpRules.Add(new IpRateLimitPolicy
            {
                Ip = "8.8.4.4",
                Rules = new List<RateLimitRule>(new RateLimitRule[] {
                new RateLimitRule {
                    Endpoint = "*:/api/testupdate",
                    Limit = 100,
                    Period = "1d" }
            })
            });

            _ipPolicyStore.Set(_options.IpPolicyPrefix, pol);
        }
    }
}