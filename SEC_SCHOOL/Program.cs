// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



/*========*/
/* Models */
/*========*/

class School
{
    public string Name { get; set; }
}
class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Teacher> Teacher { get; set; }
    public TimeOnly Period { get; set; }
}

class SchoolClass
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
}

class Teacher
{
    public int Id { get; set; }
    public virtual string FirstName {get; set;}
    public virtual string LastName { get; set;}
    public virtual List<Subject> Subjects { get; set; }
}

class Student
{
    public int Id { get; set; }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual List<Subject> Subjects { get; set; }
    public virtual SchoolClass Class { get; set;}
}

class Principal
{
    public virtual int Id { get; set; }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual School School { get; set; }

}


internal class ClassMap<T>
{

}
z

/*==========*/
/* Mappings */
/*==========*/
public class SchoolMap : ClassMap<School>
{
    public SchoolMap()
    {
        Id(x => x.Id)
    }
}