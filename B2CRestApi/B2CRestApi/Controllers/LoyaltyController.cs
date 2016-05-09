using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using B2CRestApi.Models;
using System.Diagnostics;
using B2CRestApi.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace B2CRestApi.Controllers
{
    //[BasicAuthenticationFilter]
    public class LoyaltyController : ApiController
    {

        // GET all objects
        public HttpResponseMessage Get()
        {
            try
            {
                using (var context = ContextManager.CreateContext())
                {
                    var users = context.Users.Select(row => row);
                    if (users.Count() != 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, users.ToList());
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, new { });
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        // GET a user objects
        public HttpResponseMessage Get(string userId)
        {
            using (var context = ContextManager.CreateContext())
            {
                var user = context.Users.Where(row => string.Compare(row.UserId, userId, true) == 0).FirstOrDefault();
                if (user != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
                return Request.CreateResponse(HttpStatusCode.OK, new { });
            }
        }

        // Put a user object
        public HttpResponseMessage Post([FromBody]JObject jsonUserId)
        {
            // Get userid
            if (jsonUserId != null)
            {
                string userId = jsonUserId["userid"].ToString();

                using (var context = ContextManager.CreateContext())
                {
                    string loyalty = this.LoyaltyNumber(userId);
                    var user = context.Users.Where(row => string.Compare(row.UserId, userId, true) == 0).FirstOrDefault();
                    if (user != null)
                    {
                        user.LoyaltyNumber = loyalty;
                    }
                    else
                    {
                        user = new LoyaltyModel
                        {
                            UserId = userId,
                            LoyaltyNumber = loyalty
                        };

                        context.Users.Add(user);
                    }

                    context.SaveChangesAsync();
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        private string LoyaltyNumber(string id)
        {
            int len = id.Length;
            if (len < 7)
                id = 'L' + id.PadLeft(7 - len, '0');
            else
                id = 'L' + id;

            return id;
        }
    }
}