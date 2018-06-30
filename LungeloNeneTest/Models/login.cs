using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LungeloNeneTest.Models
{
		public class login
		{
				[Required]
				[Display(Name = "User name")]
				public string username { get; set; }

				[Required]
				[DataType(DataType.Password)]
				[Display(Name = "password")]
				public string password { get; set; }


				[Display(Name = "Remember on this computer")]
				public bool RememberMe { get; set; }

				public bool IsValid(string username, string password) {
						string conn = ConfigurationManager.ConnectionStrings["JuniorExamCon"].ConnectionString;
						using (var con = new SqlConnection(conn)) {
								string sql = @"Select [username] From [dbo].[JuniorExamDb] " + "Where [username] = @us AND [password]=@pass";
								var cmd = new SqlCommand(sql, con);
								cmd.Parameters
										.Add(new SqlParameter("@u", SqlDbType.NVarChar))
										.Value = username;
								cmd.Parameters
										.Add(new SqlParameter("@p", SqlDbType.NVarChar))
										.Value = password;
								con.Open();
								var reader = cmd.ExecuteReader();
								if (reader.HasRows)
								{
										reader.Dispose();
										cmd.Dispose();
										return true;
								}
								else
								{
										reader.Dispose();
										cmd.Dispose();
										return false;
								}

						}
				}
		}


}