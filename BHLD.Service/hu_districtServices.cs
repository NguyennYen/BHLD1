﻿using BHLD.Data.Infrastructure;
using BHLD.Data.Repositories;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Services
{
    public interface Ihu_districtServices 
    {
        hu_district Add(hu_district hu_District);
        void Update(hu_district hu_District);
        hu_district Delete(int id);
        IEnumerable<hu_district> GetAll();
        IEnumerable<hu_district> GetAllByPaging(int tag, int page, int pageSize, out int totalRow);
        hu_district GetById(int id);
        IEnumerable<hu_district> GetAllPaging(int page, int pageSize, out int totalRow);
        void SaveChanges();

    }

    public class hu_districtServices : Ihu_districtServices
    {
        hu_districtRepository _hu_districtRepository;
        IUnitOfWork _unitOfWork;
        public hu_districtServices(hu_districtRepository hu_districtRepository, IUnitOfWork unitOfWork)
        {
                this._hu_districtRepository = hu_districtRepository;
                this._unitOfWork = unitOfWork;
        }

        public hu_district Add(hu_district hu_Title)
        {
            return _hu_districtRepository.Add(hu_Title);
        }

        public hu_district Delete(int id)
        {
            return _hu_districtRepository.Delete(id);
        }

        public IEnumerable<hu_district> GetAll()
        {
            return _hu_districtRepository.GetAll(new string[] { "District" });
        }



        public IEnumerable<hu_district> GetAllByPaging(int tag, int page, int pageSize, out int totalRow)
        {
            return _hu_districtRepository.GetAllByDistrict(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<hu_district> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _hu_districtRepository.GetMultiPaging(x => x.status, out totalRow, page, pageSize);

        }



        public hu_district GetById(int id)
        {
            return _hu_districtRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(hu_district hu_District)
        {
            _hu_districtRepository.Update(hu_District);
        }
    }
}
