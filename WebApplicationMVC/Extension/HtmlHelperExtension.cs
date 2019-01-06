using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Extension
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };

            return new HtmlString(JsonConvert.SerializeObject(model, settings));
        }

        /// <summary>
        /// Crea i link di paginazione Next / Previous
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="queryOptions"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public static MvcHtmlString BuildNextPreviousLinks(
        this HtmlHelper htmlHelper, QueryOptions queryOptions, string actionName)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
            string s;

            s = string.Format(
              "<nav aria-label=\"Page navigation example\">" +
              "    <ul class=\"pagination\">" +
              "      <li class=\"page-item {0}\">{1}</li>" +
              "      {2}" +
              "      <li class=\"page-item {3}\">{4}</li>" +
              "    </ul>" +
              "</nav>",
            IsPreviousDisabled(queryOptions),
            BuildPreviousLink(urlHelper, queryOptions, actionName),
            BuildPagination(urlHelper, queryOptions, actionName),
            IsNextDisabled(queryOptions),
            BuildNextLink(urlHelper, queryOptions, actionName)
            );

            return new MvcHtmlString(s);
        }

        private static string IsPreviousDisabled(QueryOptions queryOptions)
        {
            return queryOptions.CurrentPage == 1 ? "disabled" : string.Empty;
        }

        private static string IsNextDisabled(QueryOptions queryOptions)
        {
            return queryOptions.CurrentPage == queryOptions.TotalPages ? "disabled" : string.Empty;
        }

        private static string BuildPreviousLink(UrlHelper urlHelper, QueryOptions queryOptions, string actionName)
        {
            return string.Format(
             "<a class=\"page-link\" href=\"{0}\" aria-label=\"true\">&larr;</span> Previous </a>",
             urlHelper.Action(actionName, new
             {
                 queryOptions.SortOrder,
                 queryOptions.SortField,
                 CurrentPage = queryOptions.CurrentPage == 1 ? queryOptions.CurrentPage : queryOptions.CurrentPage - 1,
                 queryOptions.PageSize
             }));
        }

        private static string BuildNextLink(UrlHelper urlHelper, QueryOptions queryOptions, string actionName)
        {
            return string.Format(
             "<a class=\"page-link\" href=\"{0}\"> Next <span aria-hidden=\"true\">&rarr;</span></a>",
             urlHelper.Action(actionName, new
             {
                 queryOptions.SortOrder,
                 queryOptions.SortField,
                 CurrentPage = queryOptions.CurrentPage == queryOptions.TotalPages ? queryOptions.CurrentPage : queryOptions.CurrentPage + 1,
                 queryOptions.PageSize
             }));
        }


        /// <summary>
        /// Crea i link di paginazione
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <param name="queryOptions"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        private static string BuildPagination(UrlHelper urlHelper, QueryOptions queryOptions, string actionName)
        {
            string result = "";
            for (int i = 1; i <= queryOptions.TotalPages; i++)
            {
                result += "<li class=\"page-item ";
                if (queryOptions.CurrentPage == i)
                result += queryOptions.CurrentPage == i ? "active" : string.Empty;
                result += "\">";
                //result += "<a class=\"page-link\" href=\"#\"> " + i + " </a>";
                result += "<a class=\"page-link\" href=\"";
                result += urlHelper.Action(actionName, new
                {
                    queryOptions.SortOrder,
                    queryOptions.SortField,
                    CurrentPage = queryOptions.CurrentPage == i ? "#" : i.ToString(),
                    queryOptions.PageSize
                });
                result += "\"> " + i + " </a>";
                result += "</li>";
            }
            return result;
        }

        /// <summary>
        /// Crea il link per effettuare l'ordinamento in tabella
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="fieldName">This is the name of the link (e.g., First Name)</param>
        /// <param name="actionName">This is the name of the action to link to (e.g., Index)</param>
        /// <param name="sortField">This is the name of the model field to sort on (e.g., FirstName).</param>
        /// <param name="queryOptions">This contains the QueryOptions currently used to sort the authors. 
        /// This is used to determine if the current field is being sorted,in which case the direction should be inversed</param>
        /// <returns></returns>
        public static MvcHtmlString BuildSortableLink(this HtmlHelper htmlHelper,
                string fieldName, string actionName, string sortField, QueryOptions queryOptions)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            var isCurrentSortField = queryOptions.SortField == sortField;

            return new MvcHtmlString(string.Format("<a href=\"{0}\">{1} {2}</a>",
              urlHelper.Action(actionName,
              new
              {
                  SortField = sortField,
                  SortOrder = (isCurrentSortField
                      && queryOptions.SortOrder == SortOrder.ASC)
                    ? SortOrder.DESC : SortOrder.ASC
              }),
              fieldName,
              BuildSortIcon(isCurrentSortField, queryOptions)));
        }

        /// <summary>
        /// Ritorna il nome dell'icpna da usare per il sort
        /// </summary>
        /// <param name="isCurrentSortField"></param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        private static string BuildSortIcon(bool isCurrentSortField, QueryOptions queryOptions)
        {
            string sortIcon = "sort";

            if (isCurrentSortField)
            {
                sortIcon += "-by-alphabet";
                if (queryOptions.SortOrder == SortOrder.DESC)
                    sortIcon += "-alt";
            }

            return string.Format("<span class=\"{0} {1}{2}\"></span>", "glyphicon", "glyphicon-", sortIcon);
        }



    }

}

