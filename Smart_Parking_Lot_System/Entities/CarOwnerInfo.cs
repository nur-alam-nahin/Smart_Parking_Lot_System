using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Entities
{
    public class CarOwnerInfo
    {
        private int _Id;
        private string _name;
        private string _phone;
        private string _email;
        private string _address;

        public CarOwnerInfo(int Id, string name, string phone , string email , string address)
        {
            _Id = Id;
            _name = name;
            _phone = phone;
            _email = email;
            _address = address;
        }


        public CarOwnerInfo(string name, string phone, string email, string address)
        {
            _name = name;
            _phone = phone;
            _email = email;
            _address = address;
        }


        public CarOwnerInfo(int Id)
        {
            _Id = Id;
        }


        public int getId()
        {
            return _Id;
        }


        public string getName()
        {
            return _name;
        }

        public string getPhone()
        {
            return _phone;
        }


        public string getEmail()
        {
            return _email;
        }

        public string getAddress()
        {
            return _address;
        }
    }
}
