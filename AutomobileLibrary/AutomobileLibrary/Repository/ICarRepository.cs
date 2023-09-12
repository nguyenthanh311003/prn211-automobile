﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using AutomobileLibrary.BussinessObject;
namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int carId);
        void insertCar(Car car);
        void deleteCar(int carID);
        void updateCar(Car car);
    }
}
