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


    public class Progr: TestBase
    { 
    public Progr()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }


        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            MyMethod();

            WebTestRequest request4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram");
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            WebTestRequest request4Dependent1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/browse/GProgram");
            request4Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request4Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            request4Dependent1.QueryStringParameters.Add("nojscss", "true", false, false);
            request4Dependent1.QueryStringParameters.Add("rand", "815082", false, false);
            request4.DependentRequests.Add(request4Dependent1);
            WebTestRequest request4Dependent2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request4Dependent2.Method = "POST";
            request4Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request4Dependent2Body = new FormPostHttpBody();
            request4Dependent2Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram\",\"pageTitle\"" +
                    ":\"Реестр госпрограмм и объектов госпрограмм\",\"type\":\"asystPage\",\"action\":\"open\"}" +
                    "");
            request4Dependent2.Body = request4Dependent2Body;
            request4.DependentRequests.Add(request4Dependent2);
            WebTestRequest request4Dependent3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/GProgram/LEFTMENU_d" +
                    "ata");
            request4Dependent3.Method = "POST";
            request4Dependent3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4Dependent3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request4Dependent3Body = new FormPostHttpBody();
            request4Dependent3Body.FormPostParameters.Add("", "{}");
            request4Dependent3.Body = request4Dependent3Body;
            request4.DependentRequests.Add(request4Dependent3);
            WebTestRequest request4Dependent4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/getZimbarList");
            request4Dependent4.Method = "POST";
            request4Dependent4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4Dependent4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request4Dependent4Body = new FormPostHttpBody();
            request4Dependent4Body.FormPostParameters.Add("", "{}");
            request4Dependent4.Body = request4Dependent4Body;
            request4.DependentRequests.Add(request4Dependent4);
            WebTestRequest request4Dependent5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/file/getFilesInfo/");
            request4Dependent5.Method = "POST";
            request4Dependent5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4Dependent5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request4Dependent5Body = new FormPostHttpBody();
            request4Dependent5Body.FormPostParameters.Add("", "{\"classname\":\"User\",\"id\":100060}");
            request4Dependent5.Body = request4Dependent5Body;
            request4.DependentRequests.Add(request4Dependent5);
            WebTestRequest request4Dependent6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/foresightTour");
            request4Dependent6.Method = "POST";
            request4Dependent6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4Dependent6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request4Dependent6Body = new FormPostHttpBody();
            request4Dependent6Body.FormPostParameters.Add("", "{\"UserLang\":\"RU\"}");
            request4Dependent6.Body = request4Dependent6Body;
            request4.DependentRequests.Add(request4Dependent6);
            WebTestRequest request4Dependent7 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/board");
            request4Dependent7.ThinkTime = 1;
            request4Dependent7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4Dependent7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4Dependent7.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            request4Dependent7.QueryStringParameters.Add("", "{+%22action%22+:+%22checkUnread%22}", false, false);
            request4Dependent7.QueryStringParameters.Add("_", "1550226834731", false, false);
            request4.DependentRequests.Add(request4Dependent7);
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/getIsViewRelatedObjects" +
                    "ForMetaView");
            request5.Method = "POST";
            request5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request5Body = new FormPostHttpBody();
            request5Body.FormPostParameters.Add("", "{\"viewName\":null}");
            request5.Body = request5Body;
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/getIsViewRelatedObjects" +
                    "ForMetaView");
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("", "{\"viewName\":\"GProgramView\"}");
            request6.Body = request6Body;
            yield return request6;
            request6 = null;

            WebTestRequest request7 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request7.Method = "POST";
            request7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request7.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request7Body = new FormPostHttpBody();
            request7Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram\",\"pageTitle\"" +
                    ":\"Все госпрограммы и их объекты\",\"type\":\"view\",\"action\":\"open\"}");
            request7.Body = request7Body;
            yield return request7;
            request7 = null;

            WebTestRequest request8 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/view/GProgramView");
            request8.Method = "POST";
            request8.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request8.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request8.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/gprogram"));
            FormPostHttpBody request8Body = new FormPostHttpBody();
            request8Body.FormPostParameters.Add("", "{}");
            request8.Body = request8Body;
            yield return request8;
            request8 = null;
        }
    }
}
