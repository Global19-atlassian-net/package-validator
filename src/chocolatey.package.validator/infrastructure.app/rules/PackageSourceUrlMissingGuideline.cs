// Copyright � 2015 - Present RealDimensions Software, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
// You may obtain a copy of the License at
// 
// 	http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace chocolatey.package.validator.infrastructure.app.rules
{
    using NuGet;
    using infrastructure.rules;

    public class PackageSourceUrlMissingGuideline : BasePackageRule
    {
        public override string ValidationFailureMessage { get { return "The nuspec has been enhanced to allow you to put in packageSourceUrl, pointing to the url where this package source resides. Consider adding it to the nuspec."; } }

        public override PackageValidationOutput is_valid(IPackage package)
        {
            return !string.IsNullOrWhiteSpace(package.PackageSourceUrl.to_string());
        }
    }
}
