﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrate;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal:GenericRepository<About>,IAboutDal
    {
    }
}
