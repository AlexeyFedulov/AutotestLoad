namespace OpenReestr2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;

    
   

    public abstract class TestBase : WebTest
    {
        public IEnumerator<WebTestRequest> MyMethod()
        {

            //base.GetRequestEnumerator();
            // Инициализация правил проверки, применяемых ко всем запросам в веб-тесте
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index");
            request1.ThinkTime = 12;
            request1.ExpectedResponseUrl = "http://autotests.pmf2-gos.pmpractice.ru/asyst/logon.aspx?ReturnUrl=%2fasyst%2fpag" +
                "e%2findex";
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request1.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            yield return request1;
            request1 = null;

            string logon = "http://autotests.pmf2-gos.pmpractice.ru/asyst/logon.aspx";
            WebTestRequest request2 = new WebTestRequest(logon);
            request2.ThinkTime = 1;
            request2.Method = "POST";
            request2.ExpectedResponseUrl = "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index";
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/logon.aspx?ReturnUrl=%2fasyst%2fpag" +
                        "e%2findex"));
            request2.QueryStringParameters.Add("ReturnUrl", "%2fasyst%2fpage%2findex", false, false);
            FormPostHttpBody request2Body = new FormPostHttpBody();
            request2Body.FormPostParameters.Add("__VIEWSTATE", this.Context["$HIDDEN1.__VIEWSTATE"].ToString());
            request2Body.FormPostParameters.Add("__VIEWSTATEGENERATOR", this.Context["$HIDDEN1.__VIEWSTATEGENERATOR"].ToString());
            request2Body.FormPostParameters.Add("__EVENTVALIDATION", this.Context["$HIDDEN1.__EVENTVALIDATION"].ToString());
            request2Body.FormPostParameters.Add("UserName", "FA");
            request2Body.FormPostParameters.Add("UserPassword", "123456");
            request2Body.FormPostParameters.Add("PersistCookie", "on");
            request2Body.FormPostParameters.Add("Button1", "Войти");
            request2.Body = request2Body;
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index");
            request3.Method = "POST";
            request3.ExpectedResponseUrl = "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index";
            request3.QueryStringParameters.Add("ReturnUrl", "%2fasyst%2fpage%2findex", false, false);
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3.Body = request3Body;
            WebTestRequest request3Dependent1 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/view/MetaTranslation");
            request3Dependent1.Method = "POST";
            request3Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            StringHttpBody request3Dependent1Body = new StringHttpBody();
            request3Dependent1Body.ContentType = "";
            request3Dependent1Body.InsertByteOrderMark = false;
            request3Dependent1Body.BodyString = "";
            request3Dependent1.Body = request3Dependent1Body;
            request3.DependentRequests.Add(request3Dependent1);
            WebTestRequest request3Dependent2 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/saveStats");
            request3Dependent2.Method = "POST";
            request3Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent2Body = new FormPostHttpBody();
            request3Dependent2Body.FormPostParameters.Add("", "{\"page\":\"http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index\",\"pageTitle\":\"Г" +
                    "лавная\",\"type\":\"asystPage\",\"action\":\"open\"}");
            request3Dependent2.Body = request3Dependent2Body;
            request3.DependentRequests.Add(request3Dependent2);
            WebTestRequest request3Dependent3 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/LEFTMENU_data" +
                    "");
            request3Dependent3.Method = "POST";
            request3Dependent3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent3Body = new FormPostHttpBody();
            request3Dependent3Body.FormPostParameters.Add("", "{}");
            request3Dependent3.Body = request3Dependent3Body;
            request3.DependentRequests.Add(request3Dependent3);
            WebTestRequest request3Dependent4 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyPoints");
            request3Dependent4.Method = "POST";
            request3Dependent4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent4Body = new FormPostHttpBody();
            request3Dependent4Body.FormPostParameters.Add("", "{}");
            request3Dependent4.Body = request3Dependent4Body;
            request3.DependentRequests.Add(request3Dependent4);
            WebTestRequest request3Dependent5 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyOrders");
            request3Dependent5.Method = "POST";
            request3Dependent5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent5Body = new FormPostHttpBody();
            request3Dependent5Body.FormPostParameters.Add("", "{}");
            request3Dependent5.Body = request3Dependent5Body;
            request3.DependentRequests.Add(request3Dependent5);
            WebTestRequest request3Dependent6 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyMeetings");
            request3Dependent6.Method = "POST";
            request3Dependent6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent6.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent6Body = new FormPostHttpBody();
            request3Dependent6Body.FormPostParameters.Add("", "{}");
            request3Dependent6.Body = request3Dependent6Body;
            request3.DependentRequests.Add(request3Dependent6);
            WebTestRequest request3Dependent7 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyReports");
            request3Dependent7.Method = "POST";
            request3Dependent7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent7.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent7Body = new FormPostHttpBody();
            request3Dependent7Body.FormPostParameters.Add("", "{}");
            request3Dependent7.Body = request3Dependent7Body;
            request3.DependentRequests.Add(request3Dependent7);
            WebTestRequest request3Dependent8 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyInitiative");
            request3Dependent8.Method = "POST";
            request3Dependent8.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent8.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent8.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent8Body = new FormPostHttpBody();
            request3Dependent8Body.FormPostParameters.Add("", "{}");
            request3Dependent8.Body = request3Dependent8Body;
            request3.DependentRequests.Add(request3Dependent8);
            WebTestRequest request3Dependent9 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/ForMeInitiati" +
                    "ve");
            request3Dependent9.Method = "POST";
            request3Dependent9.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent9.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent9.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent9Body = new FormPostHttpBody();
            request3Dependent9Body.FormPostParameters.Add("", "{}");
            request3Dependent9.Body = request3Dependent9Body;
            request3.DependentRequests.Add(request3Dependent9);
            WebTestRequest request3Dependent10 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/ChReqForAppro" +
                    "ve");
            request3Dependent10.Method = "POST";
            request3Dependent10.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent10.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent10.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent10Body = new FormPostHttpBody();
            request3Dependent10Body.FormPostParameters.Add("", "{}");
            request3Dependent10.Body = request3Dependent10Body;
            request3.DependentRequests.Add(request3Dependent10);
            WebTestRequest request3Dependent11 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyDocs");
            request3Dependent11.Method = "POST";
            request3Dependent11.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent11.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent11.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent11Body = new FormPostHttpBody();
            request3Dependent11Body.FormPostParameters.Add("", "{}");
            request3Dependent11.Body = request3Dependent11Body;
            request3.DependentRequests.Add(request3Dependent11);
            WebTestRequest request3Dependent12 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyRisksPie");
            request3Dependent12.Method = "POST";
            request3Dependent12.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent12.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent12.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent12Body = new FormPostHttpBody();
            request3Dependent12Body.FormPostParameters.Add("", "{}");
            request3Dependent12.Body = request3Dependent12Body;
            request3.DependentRequests.Add(request3Dependent12);
            WebTestRequest request3Dependent13 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyDashboards");
            request3Dependent13.Method = "POST";
            request3Dependent13.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent13.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent13.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent13Body = new FormPostHttpBody();
            request3Dependent13Body.FormPostParameters.Add("", "{}");
            request3Dependent13.Body = request3Dependent13Body;
            request3.DependentRequests.Add(request3Dependent13);
            WebTestRequest request3Dependent14 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/RiskMatrix");
            request3Dependent14.Method = "POST";
            request3Dependent14.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent14.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent14.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent14Body = new FormPostHttpBody();
            request3Dependent14Body.FormPostParameters.Add("", "{}");
            request3Dependent14.Body = request3Dependent14Body;
            request3.DependentRequests.Add(request3Dependent14);
            WebTestRequest request3Dependent15 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MessagesForMe" +
                    "");
            request3Dependent15.Method = "POST";
            request3Dependent15.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent15.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent15.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent15Body = new FormPostHttpBody();
            request3Dependent15Body.FormPostParameters.Add("", "{}");
            request3Dependent15.Body = request3Dependent15Body;
            request3.DependentRequests.Add(request3Dependent15);
            WebTestRequest request3Dependent16 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyProjects");
            request3Dependent16.Method = "POST";
            request3Dependent16.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent16.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent16.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent16Body = new FormPostHttpBody();
            request3Dependent16Body.FormPostParameters.Add("", "{}");
            request3Dependent16.Body = request3Dependent16Body;
            request3.DependentRequests.Add(request3Dependent16);
            WebTestRequest request3Dependent17 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/datasource/page/Index/MyContracts");
            request3Dependent17.Method = "POST";
            request3Dependent17.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent17.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent17.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent17Body = new FormPostHttpBody();
            request3Dependent17Body.FormPostParameters.Add("", "{}");
            request3Dependent17.Body = request3Dependent17Body;
            request3.DependentRequests.Add(request3Dependent17);
            WebTestRequest request3Dependent18 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/admin/getZimbarList");
            request3Dependent18.Method = "POST";
            request3Dependent18.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent18.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent18.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent18Body = new FormPostHttpBody();
            request3Dependent18Body.FormPostParameters.Add("", "{}");
            request3Dependent18.Body = request3Dependent18Body;
            request3.DependentRequests.Add(request3Dependent18);
            WebTestRequest request3Dependent19 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/file/getFilesInfo/");
            request3Dependent19.Method = "POST";
            request3Dependent19.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent19.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent19.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent19Body = new FormPostHttpBody();
            request3Dependent19Body.FormPostParameters.Add("", "{\"classname\":\"User\",\"id\":100060}");
            request3Dependent19.Body = request3Dependent19Body;
            request3.DependentRequests.Add(request3Dependent19);
            WebTestRequest request3Dependent20 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/dataset/foresightTour");
            request3Dependent20.Method = "POST";
            request3Dependent20.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent20.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent20.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            FormPostHttpBody request3Dependent20Body = new FormPostHttpBody();
            request3Dependent20Body.FormPostParameters.Add("", "{\"UserLang\":\"RU\"}");
            request3Dependent20.Body = request3Dependent20Body;
            request3.DependentRequests.Add(request3Dependent20);
            WebTestRequest request3Dependent21 = new WebTestRequest("http://autotests.pmf2-gos.pmpractice.ru/asyst/api/board");
            request3Dependent21.ThinkTime = 23;
            request3Dependent21.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3Dependent21.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent21.Headers.Add(new WebTestRequestHeader("Referer", "http://autotests.pmf2-gos.pmpractice.ru/asyst/page/index"));
            request3Dependent21.QueryStringParameters.Add("", "{+%22action%22+:+%22checkUnread%22}", false, false);
            request3Dependent21.QueryStringParameters.Add("_", "1550226809217", false, false);
            request3.DependentRequests.Add(request3Dependent21);
            yield return request3;
            request3 = null;
        }
    }
}
