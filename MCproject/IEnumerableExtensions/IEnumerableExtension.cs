using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCproject.Models;
namespace MCproject.IEnumerableExtensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> Items)
        {
            List<SelectListItem> List = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem

            {
                Text = "select----",
                Value = "0"

            };
            List.Add(sli);

            foreach (var Item in Items)
            {


                sli = new SelectListItem
                {
                    //  Text = Item.("name"),
                    //  Value = Item.GetPropertyValue("id")
                    Text = Item.GetType().GetProperty("Name").GetValue(Item, null).ToString(),
                    Value = Item.GetType().GetProperty("Id").GetValue(Item, null).ToString(),


                };

                List.Add(sli);
            }
            return List;
        }
    }
}

