using Practice_Abstraction;

Employee employee1 = new ProjectManager()
{
    FirstName = "Hasan",
    LastName = "Çıldırmış",
    Department = "Project Manager"
};

Employee employee2 = new SoftwareDeveloper()
{
    FirstName = "Emily",
    LastName = "Smith",
    Department = "Software Developer"
};

Employee employee3 = new SalesRepresentative()
{
    FirstName = "John",
    LastName = "Doe",
    Department = "Sales Representative"
};

employee1.Task();
employee2.Task();
employee3.Task();