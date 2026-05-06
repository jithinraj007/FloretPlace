using BrandBucket_DataAccess.Repository.IRepository;
using BrandBucket_Models;
using BrandBucket_Utility;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BrandBucket_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropdownList(string obj)
        {
            if (obj == WC.CategoryName)
            {
                return _db.Category.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }
            return null;
        }

        public new IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedEnumerable<Product>> orderBy = null, string includeProperties = null, bool isTracking = true)
        {
            try
            {
                IQueryable<Product> query = _db.Product;
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (includeProperties != null)
                {
                    foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(includeProp);
                    }
                }
                if (orderBy != null)
                {
                    query = (IQueryable<Product>)orderBy(query);
                }
                if (!isTracking)
                {
                    query = query.AsNoTracking();
                }

                return query.ToList();
            }
            catch (SqlException ex) when (ex.Message.Contains("Invalid column name 'Image'"))
            {
                try
                {
                    // Support databases that use ImageUrl instead of Image.
                    var query = _db.Product.FromSqlRaw("SELECT Id, Name, Description, ShortDesc, Price, CategoryId, ImageUrl AS Image FROM Product");
                    return ApplyQueryOptions(query, filter, orderBy, includeProperties, isTracking).ToList();
                }
                catch (SqlException imageUrlEx) when (imageUrlEx.Message.Contains("Invalid column name 'ImageUrl'"))
                {
                    // If neither column exists, keep app alive by projecting null into Image.
                    var query = _db.Product.FromSqlRaw("SELECT Id, Name, Description, ShortDesc, Price, CategoryId, CAST(NULL AS nvarchar(max)) AS Image FROM Product");
                    return ApplyQueryOptions(query, filter, orderBy, includeProperties, isTracking).ToList();
                }
            }
        }

        public void Update(Product obj)
        {
            _db.Product.Update(obj);
        }

        private IQueryable<Product> ApplyQueryOptions(
            IQueryable<Product> query,
            Expression<Func<Product, bool>> filter,
            Func<IQueryable<Product>, IOrderedEnumerable<Product>> orderBy,
            string includeProperties,
            bool isTracking)
        {
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            if (orderBy != null)
            {
                query = (IQueryable<Product>)orderBy(query);
            }
            if (!isTracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }
    }
}
