using BHLD.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace BHLD.Web.Controllers
{
   [RoutePrefix("api/title")]
    public class TitleController : ApiController
    {
        Ihu_titleServices _ihu_TitleServices;
        public TitleController(IErrorService errorService, Ihu_titleServices ihu_TitleServices) 
        {
            this._ihu_TitleServices = ihu_TitleServices;
        }
        [Authorize]
        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage getall()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var listTitle = _ihu_TitleServices.GetAll();

            response = Request.CreateResponse(HttpStatusCode.OK, listTitle);

            return response;
        }
    }
}
