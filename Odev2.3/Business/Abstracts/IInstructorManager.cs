﻿using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Abstracts
{
    public interface IInstructorManager
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);   
        void Delete(Instructor instructor);
        void Update(Instructor instructor);
    }
}
