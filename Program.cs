
/*
//ex01
Person person1 = new Person();
person1.Name="Anderson";
person1.Age=35;
person1.Shorty=true;
person1.ToPresent();
//ex2
Person person2 = new();
person2.Name="Soares";
person2.Age=55;
person2.ToPresent();
//ex3
Person person3 = new()
{
  Name="Andrade",
  Age=19,
  Shorty=false
};

string res=person3.VerifyAge();
Console.WriteLine(res);

*/

Student Aluno = new();
Aluno.Name="Andrade";
Aluno.Average=78;
Console.WriteLine($"{Aluno.Name}  -  {Aluno.Average} ");