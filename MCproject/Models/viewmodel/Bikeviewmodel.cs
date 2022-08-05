using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCproject.IEnumerableExtensions;
namespace MCproject.Models.viewmodel
{
    public class Bikeviewmodel
    {
        public Bike Bike { get; set; }
        public IEnumerable<make> Makes { get; set; }
        public IEnumerable<models> Models { get; set; }



        public IEnumerable<currency> currencies { get; set; }
        public IEnumerable<SelectListItem> CSelectListItem<T>(IEnumerable<T> Items)
        {
            List<SelectListItem> List = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "---Select---",
                Value = "0"
            };
            List.Add(sli);
            foreach (var item in Items)
            {
                sli = new SelectListItem
                {
                    Text = item.GetType().GetProperty("Name").GetValue(item, null).ToString(),
                    Value = item.GetType().GetProperty("Id").GetValue(item, null).ToString()
                };
                List.Add(sli);
            }
            return List;
        }
        public List<currency> clist = new List<currency>();
        public List<currency> createlist()
        {
            clist.Add(new currency("usd", "usd"));
            clist.Add(new currency("inr", "inr"));

            clist.Add(new currency("eur", "eur"));

            return clist;
        }
        public Bikeviewmodel()// cponstructor of bikeviewmodel
        {
            currencies = createlist();//it autometically added at time of object initilizing
        }
    }
    public class currency
    {
        public string Id { get; set; }
        public string name { get; set; }

        public currency(string id, string value)//this is constructor to the currency class
        {
            Id = id;
            name = value;
        }
    }
}
    
//        public IEnumerable<SelectListItem> CselectListItem(IEnumerable<make> Items)
//        {
//            List<SelectListItem> MakeList = new List<SelectListItem>();
//            SelectListItem sli = new SelectListItem
//            {

//                Text = "select----",
//                Value = "0"

//            };
//            MakeList.Add(sli);


//            foreach (make model in Items)
//            {
//                sli = new SelectListItem
//                {
//                    Text = model.name,
//                    Value = model.id.ToString()

//                };

//                MakeList.Add(sli);
//            }
//            return MakeList;
//        }
//        public IEnumerable<SelectListItem> selectListItem(IEnumerable<models> Items)
//        {
//            List<SelectListItem> modelList = new List<SelectListItem>();
//            SelectListItem slli = new SelectListItem
//            {

//                Text = "select----",
//                Value = "0"

//            };
//            modelList.Add(slli);


//            foreach (models Model in Items)
//            {
//                slli = new SelectListItem
//                {
//                    Text = Model.name,
//                    Value = Model.id.ToString()

//                };

//                modelList.Add(slli);
//            }
//            return modelList;
//        }


//    }
//}



