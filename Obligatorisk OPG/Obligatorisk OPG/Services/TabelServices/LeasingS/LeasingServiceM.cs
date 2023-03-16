using static System.Net.Mime.MediaTypeNames;
using System;
using Obligatorisk_OPG.Model;
using System.Numerics;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;
using System.Data.SqlClient;

namespace Obligatorisk_OPG.Services.TabelServices.LeasingS
{
    public class LeasingServiceM : ILeasingServiceM
    {
        //public void AddLeasing(Leasing leasing)
        //{
        //    SQL_Leasing.AddLeasing(leasing );
        //}

        public void AddLeasing(Leasing leasing)
        {
            if (SQL_Leasing.LeasingExists(leasing.LeasingNo))
            {
                throw new ArgumentException("LeasingNo already exists");
            }
            else
            {
                SQL_Leasing.AddLeasing(leasing);
            }
        }


        public IEnumerable<Leasing> GetAll()
        {
            return SQL_Leasing.GetAllLeasings();
        }



        public IEnumerable<Leasing> GetAllLeasing()
        {
            return SQL_Leasing.GetAllLeasings();
        }

        public IEnumerable<Leasing> GetLeasings()
        {
            return SQL_Leasing.GetAllLeasings();
        }

        public IEnumerable<Leasing_Student> GetLeasingStudent(int id)
        {
            return SQL_Leasing.GetLeasingStudent(id);
            
        }

        public IEnumerable<Room> GetAllAvailableRooms()
        {
            return SQL_Leasing.GetAllAvailableRooms();
        }
    }
}
