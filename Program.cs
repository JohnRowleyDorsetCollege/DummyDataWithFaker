// See https://aka.ms/new-console-template for more information
using DummyDataWithFaker.Models;
using DummyDataWithFaker.Services;

//Console.WriteLine("Using Faker to generate dummy data");

//var user = new UserProfile();


//user.Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix);

//user.Followers = Faker.RandomNumber.Next(0, 1000);

//user.Area = $"{Faker.Address.Country()} , { Faker.Address.City()}";

//Console.WriteLine($"{user.Name} has {user.Followers} followers at {user.Area}");

foreach ( var user in GenerateDataService.UserProfiles())
{

    Console.WriteLine(user.ToString());

}