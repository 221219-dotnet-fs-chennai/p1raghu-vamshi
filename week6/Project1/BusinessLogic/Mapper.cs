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

        public static IEnumerable<Modules.UserDetails> Map(List<Da.UserDetail> userDetails)
        {
           return userDetails.Select(Map);
        }
        public static Modules.Education Map(Da.Education ed)
        {
            return new Modules.Education()
            {
                userId = ed.UserId,
                RollNo= ed.RollNo,
                University = ed.University,
                UG = ed.UG,
                Specialization = ed.Specialization,
                PassedOutYear = ed.PassedOutYear,
                Grade = ed.Grade,
            };
        }
        public static Da.Education Map(Modules.Education ed)
        {
            return new Da.Education()
            {
                UserId = ed.userId,
                RollNo = ed.RollNo,
                University = ed.University,
                UG = ed.UG,
                Specialization = ed.Specialization,
                PassedOutYear = ed.PassedOutYear,
                Grade = ed.Grade,
            };
        }
        public static IEnumerable<Modules.Education> Map(List<Da.Education> education)
        {
            return education.Select(Map);
        }
        public static Modules.Address Map(Da.Address ass)
        {
            return new Modules.Address()
            {
               userId= ass.UserId,
               PhoneNumber= ass.PhoneNumber,
               userAddress= ass.UserAddress,
               country= ass.Country,
               pincode= ass.Pincode,
            };
        }
        public static Da.Address Map(Modules.Address ass)
        {
            return new Da.Address()
            {
                UserId = ass.userId,
                PhoneNumber= ass.PhoneNumber,
                UserAddress=ass.userAddress,
                Country= ass.country,
                Pincode= ass.pincode,
            };
        }
        public static IEnumerable<Modules.Address> Map(List<Da.Address> address)
        {
            return address.Select(Map);
        }
        public static Modules.Company Map(Da.Company com)
        {
            return new Modules.Company()
            {
                userId = com.UserId,
                CompanyId= com.CompanyId,
                CompanyName = com.CompanyName,
                CompanyLocation = com.CompanyLocation,
                Experience = com.Experience,
                CompanyEmail= com.CompanyEmail,
                Website = com.Website,
            };
         }
        public static Da.Company Map(Modules.Company com)
        {
            return new Da.Company()
            {
                UserId = com.userId,
                CompanyId = com.CompanyId,
                CompanyName = com.CompanyName,
                CompanyLocation = com.CompanyLocation,
                Experience = com.Experience,
                CompanyEmail = com.CompanyEmail,
                Website = com.Website,
            };
        }
        public static IEnumerable<Modules.Company> Map(List<Da.Company> company)
        {
            return company.Select(Map);
        }
    }
}
