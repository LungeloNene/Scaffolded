using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LungeloNeneTest.Models
{
		public class Add
		{
				public string name { get; set; }
				public string surname { get; set; }
				public string phone { get; set; }
				public string email { get; set; }
				public string color { get; set; }
		}

		//public void add(Add add)
		//{
		//		string conn = ConfigurationManager.ConnectionStrings["JuniorExamCon"].ConnectionString;

		//		using(SqlConnection con = new SqlConnection(conn))
		//		{
		//				//SqlCommand cmd = new SqlConnection("InsertAll", con);
		//				cmd.CommandType = System.Data.CommandType.StoredProcedure;
		//				SqlParameter name = new SqlParameter();
		//				name.ParameterName = @"name";
		//				name.Value = add.name;
		//				cmd.Parameters.Add(name);


		//				SqlParameter surname = new SqlParameter();
		//				surname.ParameterName = @"surname";
		//				surname.Value = add.surname;
		//				cmd.Parameters.Add(surname);


		//				SqlParameter phone = new SqlParameter();
		//				phone.ParameterName = @"phone";
		//				phone.Value = add.phone;
		//				cmd.Parameters.Add(phone);

		//				SqlParameter email = new SqlParameter();
		//				email.ParameterName = @"email";
		//				email.Value = add.email;
		//				cmd.Parameters.Add(email);

		//				SqlParameter color = new SqlParameter();
		//				color.ParameterName = @"color";
		//				color.Value = add.color;
		//				cmd.Parameters.Add(color);

		//		}



		}
}