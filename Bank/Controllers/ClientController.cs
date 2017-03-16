using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bank.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Bank.Controllers
{
    public class ClientController : ApiController
    {
        BankContext db = new BankContext();

        // GET: api/Clients
        public HttpResponseMessage GetClient()
        {
            var clients = db.Client.Select(x => new
            {
                fullName = x.fullName,
                birthday = x.birthday,
                email = x.email
            });
            return Request.CreateResponse(HttpStatusCode.OK, clients);
        }

        // GET: api/Clients/5
        public HttpResponseMessage GetClient(int id)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Клиент не найден");
            }

            return Request.CreateResponse(HttpStatusCode.OK, client);
        }

        // POST: api/Clients
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Client.Add(client);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = client.id }, client);
        }

        // DELETE: api/Clients/5
        public IHttpActionResult DeleteClient(int id)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            db.Client.Remove(client);
            db.SaveChanges();

            return Ok(client);
        }
    }
}
