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
            To<ImportPackageXmlMigration>(new Guid("1053C7FE-F623-4BFF-8C5F-AC600A720D99"));
        }
    }
}