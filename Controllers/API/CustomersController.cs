﻿using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;
using Vidly.DTO;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Customers
                .Include(c => c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>));
        }

        //GET /api/customer/2
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map < Customer, CustomerDto >(customer));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri($"{Request.RequestUri}/{customer.Id}"), customerDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var dbCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (dbCustomer == null)
            {
                return NotFound();
            }

            Mapper.Map(customerDto, dbCustomer);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var dbCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (dbCustomer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(dbCustomer);
            _context.SaveChanges();

            return Ok();
        }
    }
}
