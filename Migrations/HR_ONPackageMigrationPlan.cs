using System;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Infrastructure.Packaging;

namespace HR_ON.Migrations
{
    public class HR_ONPackageMigrationPlan : PackageMigrationPlan
    {
        public HR_ONPackageMigrationPlan()
            : base("HR_ON")
        {
        }

        protected override void DefinePlan()
        {
            To<ImportPackageXmlMigration>(new Guid("fd68b8a4-31ac-4247-8a59-b9f9655fa72d"));
        }
    }
}