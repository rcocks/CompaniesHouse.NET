﻿using FluentAssertions;
using LiberisLabs.CompaniesHouse.Response;
using LiberisLabs.CompaniesHouse.Response.CompanyProfile;
using LiberisLabs.CompaniesHouse.Tests.MapProviders;
using NUnit.Framework;

namespace LiberisLabs.CompaniesHouse.Tests
{
    [SetUpFixture]
    public class Initializer
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<CompanyTypesMapProvider, CompanyType>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<CompanyStatusMapProvider, CompanyStatus>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<CompanyStatusDetailMapProvider, CompanyStatusDetail>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<LastAccountsTypeMapProvider, LastAccountsType>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<JurisdictionMapProvider, Jurisdiction>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<OfficerRoleMapProvider, OfficerRole>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<FilingCategoriesMapProvider, FilingCategory>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<FilingSubcategoriesMapProvider, FilingSubcategory>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<ResolutionCategoriesMapProvider, ResolutionCategory>>();
            AssertionOptions.EquivalencySteps.Insert<ComparingEnumWith<FilingHistoryStatusMapProvider, FilingHistoryStatus>>();
        }
    }
}
