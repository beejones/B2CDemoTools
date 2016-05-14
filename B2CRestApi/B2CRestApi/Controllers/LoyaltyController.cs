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
    public class LoyaltyController : ApiController
    {
        /// <summary>
        /// Store a user object and create the loyalty number if not existent
        /// </summary>
        /// <param name="jsonUserId">Json structure containing userid</param>
        /// <returns>Response message</returns>
        [Authorize(Roles = "client")]
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

        /// <summary>
        /// Convert object id into loyalty number
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns></returns>
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