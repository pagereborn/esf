using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EsportsFundraising.Models
{
    public class Organization
    {
        private Int32 _organizationID = 0;
        private string _name = "";
        private string _state = "";
        private string _postalCode = "";
        private Int32 _members = 0;
        private Int32 _salesRepID = 0;
        private Int32 _active = 0;

        public Int32 OrganizationID
        {
            get
            {
                return _organizationID;
            }
            set
            {
                _organizationID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                _postalCode = value;
            }
        }

        public Int32 Members
        {
            get
            {
                return _members;
            }
            set
            {
                _members = value;
            }
        }

        public Int32 SalesRepID
        {
            get
            {
                return _salesRepID;
            }
            set
            {
                _salesRepID = value;
            }
        }

        public Int32 Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }
    }
    public class ESFDB : DbContext
    {
        public DbSet<Organization> Organizations {get;set;}
    }
}