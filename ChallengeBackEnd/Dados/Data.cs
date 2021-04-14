using System;
using System.Collections.Generic;

namespace ChallengeBackEnd.Dados
{
    public class Data
    {
        public (bool status, string msg) Add(DataModel data)
        {
            try
            {
                var con = new Con();

                var sql = $"Insert into DATA (FirstName, LastName, Participation) values ({data.FirstName}, {data.LastName}, {data.Participation})";

                var ret = con.Run(sql);

                if (ret)
                    return (true, "Saved successfully!");
                else
                    return (false, "Unable to save.");
            }
            catch (Exception ex)
            {
                return (false, $"Error! {ex.Message} {ex.InnerException?.Message}");
            }
        }
        
        public (bool status, string msg) Delete(int Id)
        {
            try
            {
                var con = new Con();

                var sql = $"delete from DATA where id = {Id}";

                var ret = con.Run(sql);

                if (ret)
                    return (true, "Successfully deleted!");
                else
                    return (false, "Unable to delete.");
            }
            catch (Exception ex)
            {
                return (false, $"Error! {ex.Message} {ex.InnerException?.Message}");
            }
        }
        
        public (List<DataModel> List, bool Status, string Msg) GetList()
        {
            try
            {
                var con = new Con();

                var sql = "select * from DATA";

                var ret = con.GetDataModel(sql);

                if (ret!=null)
                    return (ret, true, "Obtained!");
                else
                    return (ret, false, "Failed to get list");
            }
            catch (Exception ex)
            {
                return (null, false, $"Error! {ex.Message} {ex.InnerException?.Message}");
            }
        }
    }

    /// <summary>
    /// Conexão com banco de dados SQL, caso existisse kkk
    /// </summary>
    public class Con
    {
        public bool Run(string command)
        {
            return true; 
        }
        
        public List<DataModel> GetDataModel(string command)
        {
            return new List<DataModel>() {
            new DataModel
            {
                Id = 1,
                FirstName = "Carlos",
                LastName = "Moura",
                Participation = 5
            },
            new DataModel
            {
                Id = 2,
                FirstName = "Fernanda",
                LastName = "Oliveira",
                Participation = 15
            },
            new DataModel
            {
                Id = 1,
                FirstName = "Hugo",
                LastName = "Silva",
                Participation = 20
            },
            new DataModel
            {
                Id = 1,
                FirstName = "Eliza",
                LastName = "Souza",
                Participation = 20
            },
            new DataModel
            {
                Id = 1,
                FirstName = "Anderson",
                LastName = "Santos",
                Participation = 40
            },
            };
        }
    }
}
