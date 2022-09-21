using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRevision
{
    //Partial preventing direct instantiation of employee class
    abstract class Employee
    {
        //Field data
        private string _empName;
        private int _empAge;
        private int _empId;
        private float _currPay;
        private string _empSSN;

        private EmployeePayTypeEnum _payType;

        //Properties
        public string Name
        {
            get { return _empName; }
            set 
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name lenght exceed 15 characters");
                else
                    _empName = value;
            }
        }
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return _empSSN; }
             set => _empSSN = value;
        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            internal set => _payType = value;
        }

        //constructors
        public Employee() { }
        public Employee(string name, int age, int id,float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = PayType;
        }
        public Employee(string name, int id, float pay,  int age)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
            _empAge = age;
        }

        //Methods
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                => Pay += amount,
                _ => Pay += 0
            };
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Age: {0}", _empAge);
            Console.WriteLine("Pay: {0}", _currPay);
        }


    }
}
