// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");

TrainingDbContext trainingDbContext = new TrainingDbContext();

List<userClass> userClassesList =  trainingDbContext.Users.ToList();
userClass userClassesNew =  trainingDbContext.Users.Where(x=>x.FirstName=="admin").FirstOrDefault();

// Console.WriteLine(userClassesNew.Count());
foreach (var user in userClassesList)
{
    Console.WriteLine(user.FirstName + " " + user.LastName);
}
// userClass userClass = new userClass();
// userClass.FirstName = "admin";
// userClass.LastName = "Bdond";
// userClass.Email = "abdBdond@gmail.com";
// userClass.Password = "abdBdond@gmail.com";
// userClass.CreatedAt = DateTime.Now;
// userClass.PhoneNumber ="12233456";
// trainingDbContext.Users.Add(userClass);
userClassesNew.FirstName = "admin2";
userClassesNew.PhoneNumber = "12admin2";
trainingDbContext.SaveChanges();

userClassesList.Remove(userClassesNew);
trainingDbContext.SaveChanges();