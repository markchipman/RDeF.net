﻿using System.Linq;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using RDeF.Data;
using RDeF.Mapping;

namespace Given_instance_of.AttributesMappingSourceProvider_class
{
    [TestFixture]
    public class when_getting_mapping_sources_for_assembly
    {
        private AttributesMappingSourceProvider Provider { get; set; }

        [Test]
        public void Should_gather_all_mapping_sources_for_that_assembly()
        {
            Provider.GetMappingSourcesFor(typeof(IProduct).GetTypeInfo().Assembly).Should().HaveCount(1).And.Subject.First().Should().BeOfType<AttributesMappingSource>();
        }

        [SetUp]
        public void Setup()
        {
            Provider = new AttributesMappingSourceProvider();
        }
    }
}
