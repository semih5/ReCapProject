﻿using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAllColors();
        IDataResult<Color> GetById(int id);
        IResult AddColor(Color color);
        IResult UpdateColor(Color color);
        IResult DeleteColor(Color color);
    }

}

