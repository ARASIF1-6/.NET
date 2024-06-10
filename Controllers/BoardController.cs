using Lab1Task.Models;
using Lab1Task.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab1Task.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board

        [Route("Board/start")]
        public ActionResult Start()
        {
            var player1 = new Player()
            {
                Id = 1,
                Name = "AR ASIF",
                Salary = 1000000000
            };

            var player2 = new Player()
            {
                Id = 2,
                Name = "AR",
                Salary = 1000000000
            };

            var staff1 = new Staff()
            {
                Id = 1,
                Name = "Jhon",
                Position = "Manager"
            };

            var staff2 = new Staff()
            {
                Id = 2,
                Name = "Roman",
                Position = "Manager"
            };

            var stadium = new Stadium()
            {
                Location = "Khilgaon, Dhaka",
                Capacity = 1000000000
            };

            var viewModel = new SampleViewModel()
            {
                Player = new List<Player> { player1, player2 },
                Staff = new List<Staff> { staff1, staff2 },
                Stadium = stadium
            };

            return View(viewModel);
        }

        [Route("Board/player")]
        public ActionResult Player()
        {
            var player = new Player()
            {
                Id = 1,
                Name = "AR ASIF",
                Salary = 1000000000
            };
            return View(player);
        }

        [Route("Board/staff")]
        public ActionResult Staff()
        {
            var staff = new Staff()
            {
                Id = 1,
                Name = "Jhon",
                Position = "Manager"
            };
            return View(staff);
        }

        [Route("Board/stadium")]
        public ActionResult Stadium()
        {
            var stadium = new Stadium()
            {
                Location = "Khilgaon, Dhaka",
                Capacity = 1000000000
            };
            return View(stadium);
        }
    }
}