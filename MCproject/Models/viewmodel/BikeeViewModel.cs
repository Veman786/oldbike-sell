using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCproject.Models.viewmodel
{
    public class BikeeViewModel
    {
        public bikeee bikeee { get; set; }
        public IEnumerable<make> Makes { get; set; }
        public IEnumerable<models> Models { get; set; }
        //public IEnumerable<Currency> currencies { get; set; }

        //private List<Currency> CList = new List<Currency>();
        //private List<Currency> CreateList()
        //{
        //    CList.Add(new Currency("USD", "USD"));
        //    CList.Add(new Currency("INR", "INR"));

        //    CList.Add(new Currency("EUR", "EUR"));


        //    return CList;
        //}
        //public BikeeViewModel()
        //{
        //    currencies = CreateList();
        //}
        //public class Currency
        //{


        //    public string Id { get; set; }
        //    public string Name { get; set; }
        //    public Currency(string id, string value)
        //    {
        //        Id = id;
        //        Name = value;
        //    }
        //}
        public IEnumerable<SelectListItem> CselectListItem(IEnumerable<make> Items)
        {
            List<SelectListItem> MakeList = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {

                Text = "select----",
                Value = "0"

            };
            MakeList.Add(sli);


            foreach (make model in Items)
            {
                sli = new SelectListItem
                {
                    Text = model.name,
                    Value = model.id.ToString()

                };

                MakeList.Add(sli);
            }
            return MakeList;
        }
        public IEnumerable<SelectListItem> selectListItem(IEnumerable<models> Items)
        {
            List<SelectListItem> modelList = new List<SelectListItem>();
            SelectListItem slli = new SelectListItem
            {

                Text = "select----",
                Value = "0"

            };
            modelList.Add(slli);


            foreach (models Model in Items)
            {
                slli = new SelectListItem
                {
                    Text = Model.name,
                    Value = Model.id.ToString()

                };

                modelList.Add(slli);
            }
            return modelList;
        }


    }
}
    


