﻿using System;
using FluentAssertions;
using NUnit.Framework;
using PropertyAttribute = RDeF.Mapping.Attributes.PropertyAttribute;

namespace Given_instance_of.PropertyAttribute_class
{
    [TestFixture]
    public class when_initializing
    {
        [Test]
        public void Should_throw_when_no_prefix_is_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute(null, null))
                .ShouldThrow<ArgumentNullException>().Which.ParamName.Should().Be("prefix");
        }

        [Test]
        public void Should_throw_when_an_empty_prefix_is_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute(String.Empty, null))
                .ShouldThrow<ArgumentOutOfRangeException>().Which.ParamName.Should().Be("prefix");
        }

        [Test]
        public void Should_throw_when_no_term_is_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute("prefix", null))
                .ShouldThrow<ArgumentNullException>().Which.ParamName.Should().Be("term");
        }

        [Test]
        public void Should_throw_when_an_empty_term_is_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute("prefix", String.Empty))
                .ShouldThrow<ArgumentOutOfRangeException>().Which.ParamName.Should().Be("term");
        }

        [Test]
        public void Should_throw_when_wrong_converter_type_is_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute("prefix", "term") { ValueConverterType = typeof(string) })
                .ShouldThrow<ArgumentOutOfRangeException>().Which.ParamName.Should().Be("valueConverterType");
        }

        [Test]
        public void Should_throw_when_no_Iri_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute() { Iri = null })
                .ShouldThrow<ArgumentNullException>().Which.ParamName.Should().Be("iri");
        }

        [Test]
        public void Should_throw_when_an_empty_Iri_is_given()
        {
            ((PropertyAttribute)null).Invoking(_ => new PropertyAttribute() { Iri = String.Empty })
                .ShouldThrow<ArgumentOutOfRangeException>().Which.ParamName.Should().Be("iri");
        }
    }
}
