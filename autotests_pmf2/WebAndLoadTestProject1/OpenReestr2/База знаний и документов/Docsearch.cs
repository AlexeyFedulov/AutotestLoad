﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenReestr2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;


    public class Docsearch : TestBase
    {

        public Docsearch()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            MyMethod();

            WebTestRequest request1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch");
            request1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            WebTestRequest request1Dependent1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request1Dependent1.Method = "POST";
            request1Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            FormPostHttpBody request1Dependent1Body = new FormPostHttpBody();
            request1Dependent1Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch\",\"pageTitle" +
                    "\":\"Поиск по документам\",\"type\":\"asystPage\",\"action\":\"open\"}");
            request1Dependent1.Body = request1Dependent1Body;
            request1.DependentRequests.Add(request1Dependent1);
            WebTestRequest request1Dependent2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/DocSearch/SearchCen" +
                    "ter");
            request1Dependent2.Method = "POST";
            request1Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            FormPostHttpBody request1Dependent2Body = new FormPostHttpBody();
            request1Dependent2Body.FormPostParameters.Add("", "{}");
            request1Dependent2.Body = request1Dependent2Body;
            request1.DependentRequests.Add(request1Dependent2);
            WebTestRequest request1Dependent3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/DocSearch/LEFTMENU_" +
                    "data");
            request1Dependent3.Method = "POST";
            request1Dependent3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            FormPostHttpBody request1Dependent3Body = new FormPostHttpBody();
            request1Dependent3Body.FormPostParameters.Add("", "{}");
            request1Dependent3.Body = request1Dependent3Body;
            request1.DependentRequests.Add(request1Dependent3);
            WebTestRequest request1Dependent4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/getZimbarList");
            request1Dependent4.Method = "POST";
            request1Dependent4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            FormPostHttpBody request1Dependent4Body = new FormPostHttpBody();
            request1Dependent4Body.FormPostParameters.Add("", "{}");
            request1Dependent4.Body = request1Dependent4Body;
            request1.DependentRequests.Add(request1Dependent4);
            WebTestRequest request1Dependent5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/file/getFilesInfo/");
            request1Dependent5.Method = "POST";
            request1Dependent5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            FormPostHttpBody request1Dependent5Body = new FormPostHttpBody();
            request1Dependent5Body.FormPostParameters.Add("", "{\"classname\":\"User\",\"id\":100060}");
            request1Dependent5.Body = request1Dependent5Body;
            request1.DependentRequests.Add(request1Dependent5);
            WebTestRequest request1Dependent6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/foresightTour");
            request1Dependent6.Method = "POST";
            request1Dependent6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            FormPostHttpBody request1Dependent6Body = new FormPostHttpBody();
            request1Dependent6Body.FormPostParameters.Add("", "{\"UserLang\":\"RU\"}");
            request1Dependent6.Body = request1Dependent6Body;
            request1.DependentRequests.Add(request1Dependent6);
            WebTestRequest request1Dependent7 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/board");
            request1Dependent7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent7.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/docsearch"));
            request1Dependent7.QueryStringParameters.Add("", "{+%22action%22+:+%22checkUnread%22}", false, false);
            request1Dependent7.QueryStringParameters.Add("_", "1551361695002", false, false);
            request1.DependentRequests.Add(request1Dependent7);
            yield return request1;
            request1 = null;
        }
    }
}
