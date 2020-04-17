using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTO;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class RentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET active rentals for the user
        [HttpGet]
        public IHttpActionResult GetRental(int customerId)
        {
            return Ok();
        }

        //GET all active rentals 
        [HttpGet]
        public IHttpActionResult GetRentals()
        {
            return Ok();
        }

        //POST Create a rental
        [HttpPost]
        public IHttpActionResult NewRental(RentalDto newRental)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
                       
            var movies = _context.Movies.Where( m => newRental.MovieIds.Contains(m.Id)).ToList();
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
                                  
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable > 0)
                {
                    movie.NumberAvailable--;

                    var rental = new Rental
                    {
                        Customer = customer,
                        Movie = movie,
                        DateRented = DateTime.Now
                    };

                    _context.Rentals.Add(rental);
                }
                else
                {
                    return BadRequest("Movie is not available.");
                }
            }

            _context.SaveChanges();

            return Ok();
        }

        //Put edit a rental
        [HttpPut]
        public IHttpActionResult EditRental(Customer customer, IEnumerable<Movie> movies)
        {
            return Ok();
        }

        //DELETE delete a rental
        [HttpDelete]
        public IHttpActionResult DeleteRental(Customer customer, IEnumerable<Movie> movies)
        {
            return Ok();
        }

    }
}
