using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsLINQQuery
{
    class clsCustomer
    {
        private string strCustomerName="";
        private string strCustomerCode="";
        private string strCity = "";
        public  string CustomerName
        {
            set
            {
                strCustomerName = value;
            }
            get
            {
                return strCustomerName;
            }
        }
        public string customerCode
        {
            set
            { strCustomerCode = value; }
            get
            { return strCustomerCode; }
        }
        public string City
        {
            set
            {
                strCity = value;
            }
            get
            {
                return strCity;
            }
        }
        public clsOrder[] Orders=null;
    }
    class clsOrder
    {
        private string strProductName;
        public string ProductName
        {
            set
            {
                strProductName = value;
            }
            get
            {
                return strProductName;
            }
        }
    }
    class clsLINQ
    {
         clsCustomer[] objCustomer = new clsCustomer[]
         {
            new clsCustomer{CustomerName="John",customerCode="001",City="CT",Orders = new clsOrder[]{new clsOrder{ProductName="TVs"}, new clsOrder{ProductName="iPhones"}}},
            new clsCustomer{CustomerName="Zach",customerCode="002",City="CA",Orders = new clsOrder[]{new clsOrder{ProductName="Laptops"}}},
            new clsCustomer{CustomerName="Dave",customerCode="003",City="AL",Orders = new clsOrder[]{new clsOrder{ProductName="DeskTops"}}},
            new clsCustomer{CustomerName="Larry",customerCode="004",City="MO",Orders = new clsOrder[]{new clsOrder{ProductName="iWatchs"}}}
         };
        
        public IEnumerable<clsCustomer> FireSimpleQuery()
        {
            return from clsCustomer Obj in objCustomer select Obj;
        }
        public IEnumerable<clsCustomer> FireQueryWithWhere(string strCustomerCode)
        {
            return from clsCustomer Obj in objCustomer  where Obj.customerCode == strCustomerCode select Obj;
        }
        public IEnumerable<clsCustomer> FireQueryWithJoin()
        {
            return from clsCustomer ObjCust in objCustomer 
                   from clsOrder ObjOrder in ObjCust.Orders
                   select ObjCust;
        }
        public IEnumerable<clsCustomer> FireQueryWithOrderBy()
        {
            return from clsCustomer ObjCust in objCustomer
                   orderby ObjCust.City
                   select ObjCust;
        }
        public void FireQueryWithGroupBy(ListBox Obj)
        {
            var GroupCustomers = from ObjCust in objCustomer
                        group ObjCust by ObjCust.City into GroupTemp
                   select new {GroupTemp.Key,GroupTemp};
            foreach (var MyTempGroup in GroupCustomers)
            {
                Obj.Items.Add(MyTempGroup.Key);
                foreach (var MyCustomer in MyTempGroup.GroupTemp)
                {
                    Obj.Items.Add(">>>" + MyCustomer.CustomerName + "  " + MyCustomer.customerCode);
                }
            }

        }
    }
}
