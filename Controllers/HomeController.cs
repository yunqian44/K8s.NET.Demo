using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using k8s.net.demo.Models;
using System.Net.Sockets;
using System.Net;

namespace k8s.net.demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var hostname = Dns.GetHostName ();
        ViewBag.HostName = hostname;
        ViewBag.HostIp = Dns.GetHostAddresses (hostname).FirstOrDefault (ip => ip.AddressFamily == AddressFamily.InterNetwork);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
