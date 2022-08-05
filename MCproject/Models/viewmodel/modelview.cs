using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCproject.Models.viewmodel
{
    public class modelview
    {
        public models Model { get; set; }
        public IEnumerable<make> makes { get; set; }
        public IEnumerable<SelectListItem> CselectListItem(IEnumerable<make> Items)
        {
            List<SelectListItem> MakeList = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {

                Text = "select----",
                Value = "0"

            };
            MakeList.Add(sli);


            foreach (make Make in Items)
            {
                sli = new SelectListItem
                {
                    Text = Make.name,
                    Value = Make.id.ToString()

                };

                MakeList.Add(sli);
            }
            return MakeList;
        }

    }
}

