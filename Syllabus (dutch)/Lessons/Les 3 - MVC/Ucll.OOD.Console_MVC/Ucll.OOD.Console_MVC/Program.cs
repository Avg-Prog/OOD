using Console_MVC.Controllers;

UserController userController = new UserController();

string menuOption = "";
do
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Add user");
    Console.WriteLine("2. Show user");
    Console.WriteLine("3. Stop program");

    menuOption = Console.ReadLine();

    switch (menuOption)
    {
        case "1":
            var createView = userController.Create();
            var model = createView.RenderView();
            createView = userController.Create(model);
            createView.RenderView();
            break;
        case "2":
            var listView = userController.List();
            listView.RenderView();

            Console.WriteLine("Pick a user:");
            var userId = int.Parse(Console.ReadLine());
            var detailView = userController.Details(userId);
            detailView.RenderView();
            break;
    }
} while (menuOption != "3");
