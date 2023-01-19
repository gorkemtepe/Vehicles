using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Entities;

namespace Vehicles.Core.Repository
{
    public class VehicleRepository
    {
        private readonly AppDBContext _context;

        public VehicleRepository(AppDBContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsByColor(string color)
        {
            return _context.Cars.Where(v => v.Color == color).ToList();
        }
        public List<Bus> GetBusesByColor(string color)
        {
            return _context.Buses.Where(v => v.Color == color).ToList();
        }
        public List<Boat> GetBoatsByColor(string color)
        {
            return _context.Boats.Where(v => v.Color == color).ToList();
        }

        public void TurnOnOffHeadlights(int id)
        {
            var car = _context.Cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                car.Headlights = !car.Headlights;
                _context.SaveChanges();
            }
        }

        public void DeleteVehicle(int id)
        {
            var car = _context.Cars.FirstOrDefault(v => v.Id == id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}
