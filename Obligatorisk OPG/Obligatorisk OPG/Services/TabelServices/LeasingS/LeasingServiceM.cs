using static System.Net.Mime.MediaTypeNames;
using System;
using Obligatorisk_OPG.Model;
using System.Numerics;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.TabelServices.LeasingS
{
    public class LeasingServiceM : ILeasingServiceM
    {
        public void AddLeasing(Leasing leasing)
        {
            SQL_Leasing.AddLeasing(leasing);
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

        public IEnumerable<Leasing_Room> GetLeasingRoom(int lid)
        {
            return SQL_Leasing.GetLeasingRoom(lid);
        }

        public IEnumerable<Room> GetAllAvailableRooms()
        {
            return SQL_Leasing.GetAllAvailableRooms();
        }
    }
}
