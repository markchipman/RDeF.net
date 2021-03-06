﻿using RDeF.Entities;

namespace RDeF.Mapping.Explicit
{
    /// <summary>Describes an abstract explicitely defined collection mapping builder.</summary>
    /// <typeparam name="TEntity">Type of the entity being mapped.</typeparam>
    public interface IExplicitCollectionMappingBuilder<TEntity> where TEntity : IEntity
    {
        /// <summary>Allows to map current collection in scope to a given <paramref name="term" />.</summary>
        /// <param name="term">Term to map to.</param>
        /// <param name="graph">Named graph to map to.</param>
        /// <returns>Instance of the <see cref="IExplicitCollectionStorageModelBuilder{TEntity}" /> that will allow to configure a storage model.</returns>
        IExplicitCollectionStorageModelBuilder<TEntity> MappedTo(Iri term, Iri graph = null);

        /// <summary>Allows to map current collection in scope to a given <paramref name="term" />.</summary>
        /// <param name="prefix">Prefix of the <paramref name="term"/>.</param>
        /// <param name="term">Term to map to.</param>
        /// <param name="graph">Named graph to map to.</param>
        /// <returns>Instance of the <see cref="IExplicitCollectionStorageModelBuilder{TEntity}" /> that will allow to configure a storage model.</returns>
        IExplicitCollectionStorageModelBuilder<TEntity> MappedTo(string prefix, string term, Iri graph = null);

        /// <summary>Allows to map current collection in scope to a given <paramref name="term" />.</summary>
        /// <param name="prefix">Prefix of the <paramref name="term"/>.</param>
        /// <param name="term">Term to map to.</param>
        /// <param name="graphPrefix">Prefix of the <paramref name="graphTerm"/>.</param>
        /// <param name="graphTerm">Graph term to map to.</param>
        /// <returns>Instance of the <see cref="IExplicitCollectionStorageModelBuilder{TEntity}" /> that will allow to configure a storage model.</returns>
        IExplicitCollectionStorageModelBuilder<TEntity> MappedTo(string prefix, string term, string graphPrefix, string graphTerm);
    }
}
