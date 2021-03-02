using Core.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult AddCarImage(IFormFile file, CarImage carImage);
        IResult UpdateCarImage(IFormFile file, CarImage carImage);
        IResult DeleteCarImage(CarImage carImage);
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAllCarImages();
        IDataResult<List<CarImage>> GetImagesOfCar(Car car);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
    }
}
