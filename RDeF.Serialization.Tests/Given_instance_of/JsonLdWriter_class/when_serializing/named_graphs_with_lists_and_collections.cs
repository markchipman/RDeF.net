﻿using System.Text;
using FluentAssertions;
using NUnit.Framework;
using RDeF;
using RDeF.Serialization;
using RDeF.Testing;

namespace Given_instance_of.JsonLdWriter_class.when_serializing
{
    [TestFixture]
    public class named_graphs_with_lists_and_collections : RdfWriterSerializationTest<JsonLdWriter>
    {
        [Test]
        public void Should_serialize_to_Json_Ld_correctly()
        {
            Encoding.UTF8.GetString(Stream.ToArray()).Cleaned().Should().Be(Expected);
        }

        protected override void ScenarioSetup()
        {
            base.ScenarioSetup();
            WithCollectionsGraph();
        }
    }
}
