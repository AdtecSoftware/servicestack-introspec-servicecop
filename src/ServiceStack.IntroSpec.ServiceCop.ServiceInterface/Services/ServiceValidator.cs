﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/. 

namespace ServiceStack.IntroSpec.ServiceCop.Core
{
    using ServiceStack.FluentValidation.Results;
    using ServiceStack.IntroSpec.Models;

    public class ServiceValidator : IServiceValidator
    {
        public ServiceValidator(RuleConfig config)
        {
            // Validators are configured/enabled via an introspec.json file
            // TODO Add a custom message provider to validators append help doc url to messages
            Validator = new ApiDocumentationValidator(config);
        }

        private ApiDocumentationValidator Validator { get; }

        public ValidationResult Validate(ApiDocumentation specResponse)
        {
            return Validator.Validate(specResponse);
        }
    }
}