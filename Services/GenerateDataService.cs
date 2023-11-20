using DummyDataWithFaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataWithFaker.Services
{
    public static class GenerateDataService
    {

        public static List<UserProfile> UserProfiles() {

            /// geneate a fake list of users 
             List<UserProfile> userProfiles = new();

          

            for (int i=0; i < 25; i++)
            {

                var user = new UserProfile();

                user.Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix);

                user.GovernmentId  = Faker.Identification.UKNationalInsuranceNumber();

                user.Bio = String.Join("", Faker.Lorem.Sentences(3));


                user.Followers = Faker.RandomNumber.Next(0, 1000);

                user.Area = $"{Faker.Address.Country()} , {Faker.Address.City()} ";

                userProfiles.Add(user);

            }

            return userProfiles;


        }


    }
}
