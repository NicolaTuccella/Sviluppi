using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class QueryOptions
    {
        public QueryOptions()
        {
            SortField = "Id";
            SortOrder = SortOrder.ASC;
            PageSize=3;
            CurrentPage = 1;

        }

        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }

        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        /// <summary>
        /// Ritorna il campo e la direzione dell'ordinamento
        /// </summary>
        public string Sort
        {   
            get
            {
                return string.Format("{0} {1}", SortField, SortOrder.ToString());
            }
        }
    }
}