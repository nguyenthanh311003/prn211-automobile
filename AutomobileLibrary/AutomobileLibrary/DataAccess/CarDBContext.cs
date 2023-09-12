using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutomobileLibrary.BussinessObject;
namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //Initialize car list
        private static List<Car> CarList = new List<Car>() {
        new Car {CarID = 1, CarName = "CRV", Manufacturer = "Honda", Price = 30000, ReleaseYear = 2021 },
        new Car {CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 15000, ReleaseYear = 2020 }
        };

        //Using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public List<Car> GetCarList() => CarList;

        public Car getCarByID(int carID)
        {
            //using LINQ to Object
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }

        //Add new car
        public void addNew(Car car)
        {
            Car pro = getCarByID(car.CarID);
            if(pro == null)
            {
                CarList.Add(pro);
            } else
            {
                throw new Exception("Car is adready exists!");
            }
        }

        //Update car
        public void updateCar(Car car)
        {
            Car pro = getCarByID(car.CarID);
            if(pro != null)
            {
                var index = CarList.IndexOf(pro);
                CarList[index] = car;
            } else
            {
                throw new Exception("Car does not adready exists!!");
            }
        }

        //Remove car
        public void removeCar(int carID)
        {
            Car pro = getCarByID(carID);
            if(pro != null)
            {
                CarList.Remove(pro);
            } else
            {
                throw new Exception("Car does not adready exists!!");
            }
        }
    }
    }

