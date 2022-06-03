using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace Server.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        
        [HttpGet()]
        public async Task Get()
        {
            var context = ControllerContext.HttpContext;

            if (!context.WebSockets.IsWebSocketRequest)
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            
            using var webSocket = await context.WebSockets.AcceptWebSocketAsync();

            while (true)
            {
                await webSocket.SendAsync(
                    Encoding.ASCII.GetBytes($".NET Rocks -> {DateTime.Now}"),
                    WebSocketMessageType.Text,
                    true,
                    CancellationToken.None);
                await Task.Delay(1000);
            }
        }
    }
}
