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


    public class initiative : TestBase
    {

        public initiative()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            MyMethod();

            

            WebTestRequest request2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative");
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            WebTestRequest request2Dependent1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/browse/Initiative");
            request2Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request2Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            request2Dependent1.QueryStringParameters.Add("nojscss", "true", false, false);
            request2Dependent1.QueryStringParameters.Add("rand", "931536", false, false);
            request2.DependentRequests.Add(request2Dependent1);
            WebTestRequest request2Dependent2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request2Dependent2.Method = "POST";
            request2Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request2Dependent2Body = new FormPostHttpBody();
            request2Dependent2Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative\",\"pageTitl" +
                    "e\":\"Реестр предложений по проекту\",\"type\":\"asystPage\",\"action\":\"open\"}");
            request2Dependent2.Body = request2Dependent2Body;
            request2.DependentRequests.Add(request2Dependent2);
            WebTestRequest request2Dependent3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Initiative/LEFTMENU" +
                    "_data");
            request2Dependent3.Method = "POST";
            request2Dependent3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2Dependent3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request2Dependent3Body = new FormPostHttpBody();
            request2Dependent3Body.FormPostParameters.Add("", "{}");
            request2Dependent3.Body = request2Dependent3Body;
            request2.DependentRequests.Add(request2Dependent3);
            WebTestRequest request2Dependent4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/getZimbarList");
            request2Dependent4.Method = "POST";
            request2Dependent4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2Dependent4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request2Dependent4Body = new FormPostHttpBody();
            request2Dependent4Body.FormPostParameters.Add("", "{}");
            request2Dependent4.Body = request2Dependent4Body;
            request2.DependentRequests.Add(request2Dependent4);
            WebTestRequest request2Dependent5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/file/getFilesInfo/");
            request2Dependent5.Method = "POST";
            request2Dependent5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2Dependent5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request2Dependent5Body = new FormPostHttpBody();
            request2Dependent5Body.FormPostParameters.Add("", "{\"classname\":\"User\",\"id\":100060}");
            request2Dependent5.Body = request2Dependent5Body;
            request2.DependentRequests.Add(request2Dependent5);
            WebTestRequest request2Dependent6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/foresightTour");
            request2Dependent6.Method = "POST";
            request2Dependent6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2Dependent6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request2Dependent6Body = new FormPostHttpBody();
            request2Dependent6Body.FormPostParameters.Add("", "{\"UserLang\":\"RU\"}");
            request2Dependent6.Body = request2Dependent6Body;
            request2.DependentRequests.Add(request2Dependent6);
            WebTestRequest request2Dependent7 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/board");
            request2Dependent7.ThinkTime = 1;
            request2Dependent7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2Dependent7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2Dependent7.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            request2Dependent7.QueryStringParameters.Add("", "{+%22action%22+:+%22checkUnread%22}", false, false);
            request2Dependent7.QueryStringParameters.Add("_", "1551335638339", false, false);
            request2.DependentRequests.Add(request2Dependent7);
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/getIsViewRelatedObjects" +
                    "ForMetaView");
            request3.Method = "POST";
            request3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("", "{\"viewName\":null}");
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/getIsViewRelatedObjects" +
                    "ForMetaView");
            request4.Method = "POST";
            request4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request4Body = new FormPostHttpBody();
            request4Body.FormPostParameters.Add("", "{\"viewName\":\"MyInitiativeView\"}");
            request4.Body = request4Body;
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request5.Method = "POST";
            request5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request5Body = new FormPostHttpBody();
            request5Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative\",\"pageTitl" +
                    "e\":\"Мои предложения по проекту\",\"type\":\"view\",\"action\":\"open\"}");
            request5.Body = request5Body;
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/view/MyInitiativeView");
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/initiative"));
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("", "{}");
            request6.Body = request6Body;
            yield return request6;
            request6 = null;
        }
    }
}
