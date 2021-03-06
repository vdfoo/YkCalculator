﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.Logic;
using YkCalculator.Model;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpPost]
        public Output Get(Input input)
        {
            FormulaManager manager = new FormulaManager();
            return manager.Identify(input);
        }

        [HttpPost("Keping")]
        public int Keping(Input input)
        {
            KepingManager manager = new KepingManager();
            return manager.Identify(input);
        }

        [HttpPost("Rod")]
        public RodSetOutput CalculateRodset(RodSetInput input)
        {
            FormulaManager manager = new FormulaManager();
            return manager.Identify(input);
        }
    }
}
