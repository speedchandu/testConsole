using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Inheritence
{
    public class GrandFather
    {
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        public string FirstName
        {
            get { return this._firstName; }
        }
        public string LastName
        {
            get
            {
                return this._lastName;
            }
        }
        public GrandFather()
        {
            this._lastName = "Thapa";
        }

        public GrandFather(string FirstName)
        {
            this._firstName = FirstName;
            this._lastName = "Thapa";
        }
        

        public virtual string Details()
        {
            return this._firstName + " " + this._lastName;
        }

        public override string ToString()
        {
            return this._firstName + " " + this._lastName;
        }
    }

    public class Father : GrandFather
    {
        protected string _middleName { get; set; }
        public string MiddleName
        {
            get
            {
                return this._middleName;
            }
        }
        public Father(string FirstName):base(FirstName)
        {
            this._middleName = "Bahadur";
        }

        public Father(string FirstName, string MiddleName):base(FirstName)
        {
            this._middleName = MiddleName;
        }

        public override string Details()
        {
            return this._firstName + " " + this._middleName + " " + this._lastName;
        }

        public override string ToString()
        {
            return this._firstName + " " + this._middleName + " " + this._lastName;
        }
    }


    public class Uncle :GrandFather
    {
        public Uncle(string FirstName):base(FirstName)
        {

        }
    }

    public class Me :Father
    {
        public Me(string FirstName):base(FirstName)
        {
            
        }

        public Me(string FirstName, string MiddleName):base(FirstName,MiddleName)
        {
            this._middleName = MiddleName;
        }
    }

    public class Son :Me
    {
        public Son(string FirstName):base(FirstName)
        {

        }
    }
}
