using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Util.GenericRepository
{
    /// <summary>
    /// Entity'ler için temel CRUD işlemlerini sağlayan generic repository arayüzü.
    /// </summary>
    /// <typeparam name="TEntity">Bu repository'nin çalışacağı entity tipi. Referans tip olmalıdır.</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Belirtilen koşula uyan entity'leri, isteğe bağlı ilişkili verilerle birlikte getirir.
        /// </summary>
        /// <param name="predicate">Uygulanacak filtre ifadesi. Null ise tüm entity'leri döndürür.</param>
        /// <param name="includes">Eager loading ile yüklenecek navigation property'ler.</param>
        /// <returns>Kriterlere uyan entity'lerin IQueryable koleksiyonu.</returns>
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate = null, params string[] includes);

        /// <summary>
        /// Primary key değerine göre tek bir entity bulur.
        /// </summary>
        /// <param name="entityKey">Bulunacak entity'nin primary key değeri.</param>
        /// <returns>Bulunursa entity; bulunamazsa null.</returns>
        TEntity FindById(object entityKey);

        /// <summary>
        /// Repository'ye yeni bir entity ekler.
        /// </summary>
        /// <param name="entity">Eklenecek entity.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Repository'ye birden fazla entity ekler.
        /// </summary>
        /// <param name="entities">Eklenecek entity koleksiyonu.</param>
        void AddAll(IEnumerable<TEntity> entities);

        /// <summary>
        /// Repository'deki mevcut bir entity'yi günceller.
        /// </summary>
        /// <param name="entity">Güncellenmiş değerleri içeren entity.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Repository'den bir entity siler.
        /// </summary>
        /// <param name="entity">Silinecek entity.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Repository'den birden fazla entity siler.
        /// </summary>
        /// <param name="entities">Silinecek entity koleksiyonu.</param>
        void DeleteAll(IEnumerable<TEntity> entities);

        /// <summary>
        /// Belirtilen koşula uyan entity sayısını döndürür.
        /// </summary>
        /// <param name="predicate">Filtre ifadesi. Null ise toplam sayıyı döndürür.</param>
        /// <returns>Kriterlere uyan entity sayısı.</returns>
        int Count(Expression<Func<TEntity, bool>> predicate = null);

        /// <summary>
        /// Belirtilen koşula uyan herhangi bir entity olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="predicate">Filtre ifadesi. Null ise herhangi bir entity var mı kontrol eder.</param>
        /// <returns>En az bir entity eşleşirse true; aksi halde false.</returns>
        bool Any(Expression<Func<TEntity, bool>> predicate = null);
    }
}
