using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities;
using WebAppForTestListenServiceBusAndEventhub.Senders;

namespace WebAppForTestListenServiceBusAndEventhub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public readonly SenderOfTestDWHTopic _senderOfTestDWHTopic;
        public readonly CDPreActivationDbContext _dbContext;



        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger, SenderOfTestDWHTopic senderOfTestDWHTopic, CDPreActivationDbContext dbContext)
        {
            _logger = logger;
            _senderOfTestDWHTopic = senderOfTestDWHTopic;
            _dbContext = dbContext;
        }



        [HttpPost]
        [Route("TestSendMessageAsync")]
        public async Task TestSendMessageAsync()
        {
            var msg = new ServiceBusMessage("TestMessage");
            var dic = msg.ApplicationProperties;
            dic["Testlogmessages"] = "1";
            await _senderOfTestDWHTopic.SendMessageAsync(msg);
        }

        [HttpPost]
        [Route("TestQueryDataAsync")]
        public async Task<IEnumerable<User>> TestQueryDataAsync()
        {

            try
            {
                var user = await _dbContext.Set<User>().Where(r => r.Id == 1).ToListAsync();
                return user;
            }
            catch (Exception ex)
            {
                return new List<User>();
            }
        }

        [HttpPost]
        [Route("TestInsertDataAsync")]
        public async Task<string> TestInsertDataAsync()
        {
            try
            {
                var user = new User();
                user.FirstName = "Li";
                user.LastName = "Yu";
                user.Gender = true;
                await _dbContext.Set<User>().AddAsync(user);
                var result = await _dbContext.SaveChangesAsync();
                return result == 1 ? "Success" : "Failed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpPost]
        [Route("TestUpdateDataAsync")]
        public async Task<string> TestUpdateDataAsync()
        {
            try
            {

                var user = await _dbContext.Users.Where(r => r.Id == 1).AsNoTracking().FirstOrDefaultAsync();
                if (user != null)
                {
                    user.FirstName = "Li";
                    user.LastName = "Yu";
                    //user.Gender = false;
                    user.Gender = true;
                    _dbContext.Set<User>().Update(user);
                    //var entityEntryOfUser = _dbContext.Entry(user);
                    //var state = entityEntryOfUser.State;
                    //var userInContext = _dbContext.Users.Find(user.Id);

                    var result = await _dbContext.SaveChangesAsync();
                    return result == 1 ? "Success" : "Failed";
                }
                else
                {
                    return "user not exist";
                }
            }
            catch (Exception ex) {
                return ex.Message;
            }
            
        }







    }
}
