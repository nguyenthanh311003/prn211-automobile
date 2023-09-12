using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        

        public Car GetCarById(int carId) => CarDBContext.Instance.getCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();

        public void insertCar(Car car) => CarDBContext.Instance.addNew(car);

        public void deleteCar(int carID) => CarDBContext.Instance.removeCar(carID);

        public void updateCar(Car car) => CarDBContext.Instance.updateCar(car);
    }
}
