using EntityApi.Entities;
using Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Da = EntityApi.Entities;
//using codefirst = Data_CodeFirst;

namespace BusinessLogic
{
    public class Mapper
    {
        public static Modules.UserDetails Map(Da.UserDetail ud)
        {
            return new Modules.UserDetails()
            {
                userId = ud.UserId,
                Age = ud.Age,
                Salutation = ud.Salutation,
                FirstName = ud.FirstName,
                MiddleName = ud.MiddleName,
                LastName = ud.LastName,
                Gender = ud.Gender,
                Email = ud.Email,
                Password = ud.Password,
            };
        }
        public static Da.UserDetail Map(Modules.UserDetails ud)
        {
            return new Da.UserDetail()
            {
                UserId = ud.userId,
                Age = ud.Age,
                Salutation = ud.Salutation,
                FirstName = ud.FirstName,
                MiddleName = ud.MiddleName,
                LastName = ud.LastName,
                Gender = ud.Gender,
                Email = ud.Email,
                Password = ud.Password,
            };
        }

        public static IEnumerable<UserDetails> Map(List<UserDetail> userDetails)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// This method converts Data's Restaurant object to Models' Restaurant Entity
        /// </summary>
        /// <param --name="r"></param>
        /// <returns>Models.Restaurant</returns>
        /* public static Models.Restaurant Map(codefirst.Restaurant r)
         {
             return new Models.Restaurant()
             {
                 Id = r.Id,
                 Name = r.Name,
                 CloseTime = Validation.HandleTimeSpanNulls(r.CloseTime),
                 Cuisine = r.Cuisine,
                 OpenTime = Validation.HandleTimeSpanNulls(r.OpenTime),
                 Email = r.Email,
                 Phone = r.Phone,
                 Website = r.Website,
                 ZipCode = r.Zipcode
             };
         }
         /// <summary>
         /// This method converts Data's Restaurant object to Models' Restaurant Entity
         /// </summary>
         /// <param name="r"></param>
         /// <returns>Models.Restaurant</returns>
         public static Models.Restaurant Map(Data.Restaurant r)
         {
             return new Models.Restaurant()
             {
                 Id = r.Id,
                 Name = r.Name,
                 CloseTime = Validation.HandleTimeSpanNulls(r.CloseTime),
                 Cuisine = r.Cuisine,
                 OpenTime = Validation.HandleTimeSpanNulls(r.OpenTime),
                 Email = r.Email,
                 Phone = r.Phone,
                 Website = r.Website,
                 ZipCode = r.Zipcode
             };
         }
         //task
         public static IEnumerable<Models.Review> Map(IEnumerable<Data.Review> reviews)
         {
             return reviews.Select(Map);
         }
         /// <summary>
         /// This method converts Models' Restaurant object to Entity Framework Restaurant Entity in DataLayer
         /// </summary>
         /// <param name="r"></param>
         /// <returns>Data.Restaurant</returns>
         public static Data.Restaurant Map(Models.Restaurant r)
         {
             return new Data.Restaurant()
             {
                 Id = r.Id,
                 Name = r.Name,
                 CloseTime = Validation.StringToTime(r.CloseTime.ToString()),
                 Cuisine = r.Cuisine,
                 OpenTime = Validation.StringToTime(r.OpenTime.ToString()),
                 Email = r.Email,
                 Phone = r.Phone,
                 Website = r.Website,
                 Zipcode = r.ZipCode
             };
         }
         /// <summary>
         /// This method converts Models' Restaurant object to Entity Framework Restaurant Entity in DataLayer
         /// </summary>
         /// <param name="r"></param>
         /// <returns>Data.Restaurant</returns>
         public static codefirst.Restaurant Map(Models.Restaurant r, string s)
         {
             return new codefirst.Restaurant()
             {
                 Id = r.Id,
                 Name = r.Name,
                 CloseTime = Validation.StringToTime(r.CloseTime.ToString()),
                 Cuisine = r.Cuisine,
                 OpenTime = Validation.StringToTime(r.OpenTime.ToString()),
                 Email = r.Email,
                 Phone = r.Phone,
                 Website = r.Website,
                 Zipcode = r.ZipCode
             };
         }
         /// <summary>
         /// This method converts Models' collection of Restaurant object to Entity Framework collection of Restaurant Entity
         /// </summary>
         /// <param name="restaurants"></param>
         /// <returns>IEnumerable<Models.Restaurant></returns>
         public static IEnumerable<Models.Restaurant> Map(IEnumerable<Data.Restaurant> restaurants)
         {
             return restaurants.Select(Map);
         }
         /// <summary>
         /// This method converts Models' collection of Restaurant object to Entity Framework collection of Restaurant Entity
         /// </summary>
         /// <param name="restaurants"></param>
         /// <returns>IEnumerable<Models.Restaurant></returns>
         public static IEnumerable<Models.Restaurant> Map(IEnumerable<codefirst.Restaurant> restaurants)
         {
             return restaurants.Select(Map);
         }*/
    }
}
