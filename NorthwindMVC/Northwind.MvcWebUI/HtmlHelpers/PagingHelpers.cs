using Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MvcWebUI.HtmlHelpers
{
    public static  class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagingInfo pagingInfo)
        {
            //<a hret="">1</a>
            int totalPage = (int)Math.Ceiling
                ((decimal)pagingInfo.TotalItems / pagingInfo.ItemsPerPage);

            var stringBuilder = new StringBuilder();
            for (int i = 1; i<=totalPage; i++)
            {
                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format("/Product/Index/?Page={0}&category= {1}", i,pagingInfo.CurrentCategory));
                tagBuilder.InnerHtml = i.ToString();
                if (pagingInfo.CurrentPage == i)
                {
                    tagBuilder.AddCssClass("selected");
                }

                stringBuilder.Append(tagBuilder);
            }

            return MvcHtmlString.Create(stringBuilder.ToString());
        }
    }
}