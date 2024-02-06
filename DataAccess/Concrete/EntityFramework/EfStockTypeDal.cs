using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStockTypeDal : EfEntityRepositoryBase<StockType, StockContext>, IStockTypeDal
    {
        public List<SelectListItem> GetAllStockTypesSelectList()
        {
            using (StockContext context = new StockContext())
            {
                var result = from s in context.StockTypes
                             select new SelectListItem
                             {
                                 Value = s.Id.ToString(),
                                 Text = s.Name,
                             };
                return result.ToList();
            }
        }
    }
}
