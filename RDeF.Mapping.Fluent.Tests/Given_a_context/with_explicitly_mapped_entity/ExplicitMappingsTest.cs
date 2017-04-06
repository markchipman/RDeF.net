﻿using NUnit.Framework;
using RDeF.Data;
using RDeF.Entities;
using RDeF.Mapping;
using RDeF.Mapping.Converters;
using RDeF.Mapping.Explicit;

namespace Given_a_context.with_explicitly_mapped_entity
{
    public abstract class ExplicitMappingsTest
    {
        protected IEntityContext Context { get; set; }

        public virtual void TheTest()
        {
        }

        [SetUp]
        public void Setup()
        {
            ScenarioSetup();
            TheTest();
        }

        protected virtual void ScenarioSetup()
        {
        }

        protected virtual void MapEntity(IExplicitMappingsBuilder<IUnmappedProduct> entity)
        {
            entity
                .MappedTo(new Iri("class1"))
                .MappedTo(new Iri("class2"))
                .WithProperty(instance => instance.Description).MappedTo(new Iri("description")).WithValueConverter<StringConverter>()
                .WithProperty(instance => instance.Name).MappedTo(new Iri("name")).WithValueConverter<StringConverter>()
                .WithCollection(instance => instance.Categories).MappedTo(new Iri("categories")).StoredAs(CollectionStorageModel.Simple).WithValueConverter<StringConverter>();
        }
    }
}