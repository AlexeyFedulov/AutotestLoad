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


    public class User : TestBase
    {

        public User()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            MyMethod();

            WebTestRequest request1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User");
            request1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            WebTestRequest request1Dependent1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/browse/User");
            request1Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request1Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            request1Dependent1.QueryStringParameters.Add("nojscss", "true", false, false);
            request1Dependent1.QueryStringParameters.Add("rand", "7086519", false, false);
            request1.DependentRequests.Add(request1Dependent1);
            WebTestRequest request1Dependent2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request1Dependent2.Method = "POST";
            request1Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request1Dependent2Body = new FormPostHttpBody();
            request1Dependent2Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User\",\"pageTitle\":\"По" +
                    "льзователи\",\"type\":\"asystPage\",\"action\":\"open\"}");
            request1Dependent2.Body = request1Dependent2Body;
            request1.DependentRequests.Add(request1Dependent2);
            WebTestRequest request1Dependent3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/User/LEFTMENU_data");
            request1Dependent3.Method = "POST";
            request1Dependent3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request1Dependent3Body = new FormPostHttpBody();
            request1Dependent3Body.FormPostParameters.Add("", "{}");
            request1Dependent3.Body = request1Dependent3Body;
            request1.DependentRequests.Add(request1Dependent3);
            WebTestRequest request1Dependent4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/getZimbarList");
            request1Dependent4.Method = "POST";
            request1Dependent4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request1Dependent4Body = new FormPostHttpBody();
            request1Dependent4Body.FormPostParameters.Add("", "{}");
            request1Dependent4.Body = request1Dependent4Body;
            request1.DependentRequests.Add(request1Dependent4);
            WebTestRequest request1Dependent5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/file/getFilesInfo/");
            request1Dependent5.Method = "POST";
            request1Dependent5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request1Dependent5Body = new FormPostHttpBody();
            request1Dependent5Body.FormPostParameters.Add("", "{\"classname\":\"User\",\"id\":100060}");
            request1Dependent5.Body = request1Dependent5Body;
            request1.DependentRequests.Add(request1Dependent5);
            WebTestRequest request1Dependent6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/foresightTour");
            request1Dependent6.Method = "POST";
            request1Dependent6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request1Dependent6Body = new FormPostHttpBody();
            request1Dependent6Body.FormPostParameters.Add("", "{\"UserLang\":\"RU\"}");
            request1Dependent6.Body = request1Dependent6Body;
            request1.DependentRequests.Add(request1Dependent6);
            WebTestRequest request1Dependent7 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/board");
            request1Dependent7.ThinkTime = 1;
            request1Dependent7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request1Dependent7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request1Dependent7.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            request1Dependent7.QueryStringParameters.Add("", "{+%22action%22+:+%22checkUnread%22}", false, false);
            request1Dependent7.QueryStringParameters.Add("_", "1551363002500", false, false);
            request1.DependentRequests.Add(request1Dependent7);
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/getIsViewRelatedObjects" +
                    "ForMetaView");
            request2.Method = "POST";
            request2.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request2Body = new FormPostHttpBody();
            request2Body.FormPostParameters.Add("", "{\"viewName\":null}");
            request2.Body = request2Body;
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/getIsViewRelatedObjects" +
                    "ForMetaView");
            request3.Method = "POST";
            request3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("", "{\"viewName\":\"UserView\"}");
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request4.Method = "POST";
            request4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request4Body = new FormPostHttpBody();
            request4Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User\",\"pageTitle\":\"Вс" +
                    "е сотрудники\",\"type\":\"view\",\"action\":\"open\"}");
            request4.Body = request4Body;
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/view/UserView");
            request5.Method = "POST";
            request5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/User"));
            FormPostHttpBody request5Body = new FormPostHttpBody();
            request5Body.FormPostParameters.Add("", "{}");
            request5.Body = request5Body;
            yield return request5;
            request5 = null;
        }
    }
}
