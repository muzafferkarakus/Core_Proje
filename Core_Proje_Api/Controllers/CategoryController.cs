﻿using Core_Proje_Api.DAL.Context;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new Context();
            return Ok(c.Categories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Category p)
        {
            using var c = new Context();
            var value = c.Find<Category>(p.CategoryId);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}

