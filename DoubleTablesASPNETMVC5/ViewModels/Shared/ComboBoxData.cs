using DoubleTablesASPNETMVC5.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoubleTablesASPNETMVC5.ViewModels.Shared
{
    public class ComboBoxData
    {
        public static SelectList GetListData(ListTypes listType)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            using (StudentDB2Context db = new StudentDB2Context())
            {
                list = db.ListTypesDatas.Where(x => x.ListTypeId == (int)listType).Select(x => new SelectListItem
                {
                    Text = x.Description,
                    Value = x.ListTypeDataId.ToString()
                }).ToList();
            }

            SelectList lst = new SelectList(list.AsEnumerable(), "Value", "Text");

            return lst;
        }
    }
}