using System.Text;

namespace StringDemo180724
{
    //WAP to compare given two strings are equal or not

    
     class StringOperations//class
    {
        public void checkLogin() //method
        {
            string uname;//user Name   //admin
            string pass;  //password    //admin@123
            Console.WriteLine("Enter user name and password");
            uname = Console.ReadLine();
            pass=Console.ReadLine();

            int n1 = string.Compare(uname, "admin");
            int n2 = string.Compare(pass, "admin@123");
            if (n1==0 && n2==0)
            {
                Console.WriteLine("User name and password mached.. welcome");
            }
            else
            {
                Console.WriteLine("invalid user name or password...");
            }
        }
        public void compareStrings()
        {
            string str1;
            string str2;

            Console.WriteLine("Enter string 1");
            str1= Console.ReadLine();
            Console.WriteLine("Enter string 2");
            str2= Console.ReadLine();
            int n=str1.CompareTo(str2);
            Console.WriteLine("n="+n);
            //if (String.Compare(str1, str2) == 0)
            //{
            //    //Console.WriteLine("string 1 and string 2 are equal");
            //    Console.WriteLine($"{str1} and {str2} are equal");
            //}
            //else
            //{
            //    Console.WriteLine($"{str1} and {str2} not equal");
            //}

            if (n==0)
            {
                Console.WriteLine($"{str1} and {str2} are equal");
            }
            else
            {
                Console.WriteLine($"{str1} and {str2} not equal");
            }

        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            //1 string declaration

            //string s1;
            //String s2="Nashik";
            //Console.WriteLine("s2 length="+s2.Length);

            ////2 declare string like object creation

            //string s3 = new String("pune");

            //Console.WriteLine(s3);
            //Console.WriteLine("add ="+s3.GetHashCode());
            //s3 = s3 + "Maharashtra ....";
            //Console.WriteLine("--------------");
            //Console.WriteLine(s3);
            //Console.WriteLine("add =" + s3.GetHashCode());

            #endregion

            #region
            //  string s1 = "Pune";
            //  string s2 = "pune";
            //                      //78,110
            //int n=  string.Compare(s1, s2);  // 0   or +1   or -1
            //                                 // 0==> when s1==s2
            //                                 //+1  ==>  s1<s2
            //                                 //-1  ==> s1>s2
            //  Console.WriteLine("n="+n);
            //  if (n==0)
            //  {
            //      Console.WriteLine("s1 and s2 are equal");
            //  }
            #endregion


            #region check two String program
            //StringOperations so = new StringOperations();

            ////so====> this object of StringOperations class

            //so.compareStrings();
            #endregion

            #region 180724

            ////step1 create object of class
            //StringOperations sobj = new StringOperations();

            ////step2 call login method using object of class

            //sobj.checkLogin();//method calling

            //string str=   string.Concat("pune", "Warje");
            // Console.WriteLine(str);
            //string ss1 = "abcd";
            //string ss2 = "xyz";

            //string ss3 = string.Concat(ss1, ss2);
            //Console.WriteLine("ss1="+ss1);
            //Console.WriteLine("ss2=" + ss2);
            //Console.WriteLine("ss3=" + ss3);
            //// combine Fname Mname and Lname of student and display


            //string fname = "rajesh";
            //string mname = "mohan";   //rajesh mohan waghmare 
            //string lname = "waghmare";
            //string studName = string.Concat(fname, " ");//rajesh__  
            //studName = string.Concat(studName,mname);//rajesh mohan
            //studName = string.Concat(studName, " ");//rajesh mohan__
            //studName = string.Concat(studName, lname);
            //Console.WriteLine("Student name is:"+studName);
            #endregion

            //string str = "pune mumbai nashik pune nagpur delhi";
            //string city = "Pimpri ";

            // Console.WriteLine(str.Contains(city));

            //char[] chArr = new char[50];
            ////city.CopyTo(chArr);
            //city.CopyTo(1, chArr, 5, 5);

            //for (int i = 0; i < chArr.Length; i++)
            //{
            //    Console.WriteLine(chArr[i]);
            //}
            // Console.WriteLine(str.IndexOf(city));
            // Console.WriteLine("******************");
            //string temp= str.Insert(31, city);
            // Console.WriteLine("temp= "+temp);
            // Console.WriteLine("str="+str);
            // Console.WriteLine("city = "+city);
            // string[] myCities = new string[] { "kolhapur", "solapur", "Sangli" };
            // // string combineCities= string.Join(',', myCities);
            // //Console.WriteLine(combineCities);
            // string combineCities = "kolhapur,solapur,sangli";
            // string[] xyz;
            // xyz=combineCities.Split(',');
            // Console.WriteLine(xyz[0]);
            // Console.WriteLine(xyz[1]);
            // Console.WriteLine(xyz[2]);

            //string city1 = "pu    ne";
            //Console.WriteLine(city1.Length+" "+city1);
            ////Console.WriteLine(string.Compare(city1.Trim(),"pune"));
            //string newCity = city1.Trim();
            //Console.WriteLine(newCity.Length + " " + newCity);

            // StringBuilder sb1 = new StringBuilder();
            // string temp = "pune";
            //  sb1.Append(temp); 
            // Console.WriteLine(sb1);
            // sb1.Append(" nashik");
            // sb1.Append("goa");
            // Console.WriteLine(sb1);
            //// string ss = sb1.ToString();
            //// Console.WriteLine(ss);
            ////string city123 = "nagar";
            //// sb1 = new StringBuilder( city123);

            //StringBuilder sb = new StringBuilder("Hello World!", 50);
            //sb.Remove(6,1);
            //Console.WriteLine(sb);
            //StringBuilder sb = new StringBuilder("Hello World!");
            //sb.Replace("World", "C#"); 
            //Console.WriteLine(sb);//output: Hello C#! 
            //Console.WriteLine(sb.Capacity);
            //sb.Clear();

        }
    }
}
