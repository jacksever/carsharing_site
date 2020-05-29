﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCars.Controllers
{
    [Route("html/[controller]")]
    public class HtmlBookController : Controller
    {
        private ICarsRepository _carsRepository { get; set; }

        public HtmlBookController(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_carsRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_carsRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Car car)
        {
            try
            {
                _carsRepository.Add(car);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("update/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_carsRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Car car)
        {
            try
            {
                _carsRepository.Update(car);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}