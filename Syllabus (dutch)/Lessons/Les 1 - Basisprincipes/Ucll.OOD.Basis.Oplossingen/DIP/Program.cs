using DIP;

Manager manager = new Manager();
manager.AssignEmployee(new Tester { Name = "Johnny Tester" });
manager.AssignEmployee(new Developer { Name = "Dennis Develop" });
manager.AssignEmployee(new Analyst { Name = "Annie Analyst" });