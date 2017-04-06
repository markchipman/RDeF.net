﻿using System;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using RDeF;
using RDeF.Data;
using RDeF.Entities;
using RDeF.Mapping;
using RDeF.Mapping.Converters;
using RDeF.Mapping.Entities;
using RDeF.Mapping.Explicit;
using RDeF.Mapping.Visitors;

namespace Given_a_context.with_explicitly_mapped_entity.when_an_entity
{
    public abstract class ScenarioTest : ExplicitMappingsTest
    {
        internal Mock<IExplicitMappings> Mappings { get; set; }

        protected IEntityMapping Mapping { get; private set; }

        protected Mock<IEntityContext> EntityContext { get; private set; }

        [Test]
        public void Should_create_entity_mappings_accordingly()
        {
            Mapping.Should().BeAssignableTo<IEntityMapping>().ContainMappingsFor(typeof(IUnmappedProduct));
        }

        protected override void ScenarioSetup()
        {
            Mappings = new Mock<IExplicitMappings>(MockBehavior.Strict);
            Mappings.Setup(instance => instance.Set(It.IsAny<IEntityMapping>())).Callback<IEntityMapping>(mapping => Mapping = mapping);
            EntityContext = new Mock<IEntityContext>(MockBehavior.Strict);
            EntityContextExtensions.ExplicitMappings[Context = EntityContext.Object] = Mappings.Object;
            EntityContextExtensions.LiteralConverters = new[] { new StringConverter() };
            EntityContextExtensions.MappingVisitors = Array.Empty<IMappingProviderVisitor>();
            EntityContextExtensions.QIriMappings = Array.Empty<QIriMapping>();
        }
    }
}