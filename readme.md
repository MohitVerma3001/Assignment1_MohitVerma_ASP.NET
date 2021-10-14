project name : Buckles
Project Purpose: This tutorial teaches ASP.NET Core MVC web development with controllers and views.
Project author: Mohit Verma
Date modified: 14-10-2021

11-06-2021
//*****PART 1 - GET STARTED ********//
10:30 - Create a new project in Visual Studio 2019 and Named the project as Buckles.
10:35 - Firstly, I select "Create new project", then select ".NET 5.0" and "Individual  authentication" and Configure https
      - the Project url is https://localhost:44351/
10:40 - the project is buitl successfully
   Ohh.... such a nice start!!!
10:45 - At this moment Part 1 is successfully finished......

//*******PART 2 - Adding a CONTROLLER ********//
10:52 - reading a basic about MVC : The Model-View-Controller (MVC) architectural pattern divides a programme into three major components: the Model, the View, and the Controller. The MVC pattern aids in the development of projects that are more testable and easier to upgrade than typical monolithic apps.
10:55 - Check the nav buttons are they working or not ..
       https://localhost:44351/Home
       https://localhost:44351/Privacy
10:58 - the project was running good......thank god :) 
11:05 - Now, I started addind a Controller
11:11 - Step 1: In the Solution Explorer, right-click Controllers > Add > Controller.   
11:17 - Step 2:In the Add Scaffold dialog box, select MVC Controller - Empty.
11:23 - Step 3: In the Add New Item - MvcMovie dialog, enter SeedDatasController.cs and select Add.
Note that Every public method in a controller is callable as an HTTP endpoint. In the sample above, both methods return a string. Note the comments preceding each method.
11:30 - Run the command https://localhost:44351/SeedDatas
11:35 - oh no........failed get a bunch of errors.......!!!
11:37 - agin after getting error even after resolving it.......whats the hell is going on....._______
11:45 - the output we get is "his is my default ction...."
11:50 -routing format is set in the Configure method in Startup.cs file.
      - add app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
12:00 - Run the command https://localhost:44351/SeedDatas/Welcome
12:10 - output is "This is the Welcomr action method..."
      |||   thank god   ||| 
      at last . . . . 
want a break.....too confusing...lots of similair commands...

oh no....it's a long time :(


//*****PART 3, add a view to an ASP.NET Core MVC app******//
19:10 - Currently the Index method returns a string with a message in the controller class. In the HelloWorldController class, replace the Index method 
19:18 - The preceding code:
      - Calls the controller's View method.
      - Uses a view template to generate an HTML response.
19:20 - Right-click on the Views folder, and then Add > New Folder and name the folder SeedData.
19:21 - Right-click on the Views/HelloWorld folder, and then Add > New Item.
19:25 - In the Add New Item - MvcMovie dialog:
19:30 - In the search box in the upper-right, enter view
      - Select Razor View - Empty
      - Keep the Name box value, Index.cshtml.
      - Select Add
19:45 - Replace the contents of the Views/SeedData/Index.cshtml Razor view file with
19:54 - The Index method in the HelloWorldController ran the statement return View();, which specified that the method should use a view template file to render a response to the browser.
//*****Change views and layout pages*******//
20:00 - Replace the content of the Views/Shared/_Layout.cshtml file
20:05 - The menu layout is implemented in the Views/Shared/_Layout.cshtml file.
20:10 - Open the Views/Shared/_Layout.cshtml file.
20:34 - Lets - Change the title, footer, and menu link in the layout file

23:10 - Three occurrences of MvcMovie to Movie App.
      - The anchor element <a class="navbar-brand" asp-area="" asp-controller="Home"     asp-action="Index">MvcMovie</a> to <a class="navbar-brand" asp-        controller="Movies" asp-action="Index">Movie App</a>.
23:30 - Save the changes and select the Privacy link. :)
23:45 - browser tab displays Privacy Policy - Movie App instead of Privacy Policy - Mvc Movie:

The build failed. Fix the build errors and run again.

I dont know why this happpening to me as i copied it from a site but still..........?????

00:28 - plan to shut it down..ARG! 
let's begin it tomorrow....didn't have more power to resolve the error.....

12-10-2021
10:10 - let begins to resolve the error
10:20 - Add little changes
    test it again.!! please work.
10:25 - oh...my....god...the error  was resolved ....there is a studid fault
10:29 - everything was checked properly and everything works well 
10:33 - PART - 3 was completed (half of the work ws done )
10: 37 - thanks god it works now...
lets have a break!!!!
I Feel tied so I will have a short nap...
11:20 - thanks god it works now...
//******PART 4, add a model to an ASP.NET Core MVC app******//
lets work fast as its too dark outside.....i gonna become night owl!|||||
11:30 - let's begin part 4
11:31 - Basics that need to be cleared
      - These model classes are used with Entity Framework Core (EF Core) to work with a database. EF Core is an object-relational mapping (ORM) framework that simplifies the data access code that you have to write.
      - The model classes created are known as POCO classes, from Plain Old CLR Objects. POCO classes don't have any dependency on EF Core. They only define the properties of the data to be stored in the database.
11:57 - Right-click the Models folder > Add > Class. Name the file SeedDatasController.cs.
12:06 - Update the Models/Movie.cs file with the provided code.
12:20 - Add NuGet packages
12:23 - From the Tools menu, select NuGet Package Manager > Package Manager Console (PMC).
12:45 - Console this package - Install-Package Microsoft.EntityFrameworkCore.Design
12:58 - Scaffold movie pages.
00:05 - In Solution Explorer, right-click the Controllers folder and select Add > New Scaffolded Item.
00:15 - In the Add Scaffold dialog, select MVC Controller with views, using Entity Framework > Add.
00:30 - Complete the Add MVC Controller with views, using Entity Framework dialog
        In the Model class drop down, select Movie (MvcMovie.Models).
        In the Data context class row, select the + (plus) sign.
        In the Add Data Context dialog, the class name MvcMovie.Data.MvcMovieContext is generated.
        Select Add.
        Views and Controller name: Keep the default.
        Select Add.
00:49 - Scaffolding creates the following:
      - A movies controller: Controllers/MoviesController.cs
      - Razor view files for Create, Delete, Details, Edit, and Index pages: Views/Movies/*.cshtml
      - A database context class: Dat+a/MvcMovieContext.cs
00:57 - From the Tools menu, select NuGet Package Manager > Package Manager Console .
01:13 - In the Package Manager Console (PMC), enter the following commands
      - Add-Migration InitialCreate
      - Update-Database
01:29 - Let's Test the project .....
01:32 - WoW wOw ist going good
01:37 - <Felling good man...> rare moment in life....its all about the proper guidence of our teacher..
-----wants a urgent break------
    |||Going to bEd|||
I was too busy as I was In College So thats why I started it Later........
15:25 - Examine the generated database context class and registration.
15:47 - Scaffolding creates the Data/MvcMovieContext.cs database context class
15:56 - Scaffolding generated the following highlighted code in Startup.ConfigureServices
16:00 - Musyt read The ASP.NET Core configuration system reads the "MvcMovieContext" database connection string.
16:09 - Examine the generated database connection string
16:25 - Scaffolding added a connection string to the appsettings.json file
16:42 - For local development, the ASP.NET Core configuration system reads the ConnectionString key from the appsettings.json file.
16:57 - save and run the function. and it works great ...seriously hardwork is the key to success......
///Tea Break :) going good till yet...

17:31 - The InitialCreate class
17:37 - Examine the Migrations/{timestamp}_InitialCreate.cs migration file
17:41 - Dependency injection in the controller
17:59 - Open the Controllers/MoviesController.cs file and examine the constructor
18:15 - save and run the function. and it works great ...seriously hardwork is the key to success......
18:33 - again Run the app, 
      - Test the Create page. Enter and submit data.
      - Test the Edit, Details, and Delete pages.
18:40 - yooo yoo working well.... :) so happy 
19:10 - Strongly typed models and the @model directive
19:35 - things to learn (remember)
      - Earlier in this tutorial, you saw how a controller can pass data or objects to a view using the ViewData dictionary. The ViewData dictionary is a dynamic object that provides a convenient late-bound way to pass information to a view.
      - MVC provides the ability to pass strongly typed model objects to a view. This strongly typed approach enables compile time code checking. The scaffolding mechanism passed a strongly typed model in the MoviesController class and views.
19:46 - SQL Logging of Entity Framework Core
20:03 - Logging configuration is commonly provided by the Logging section of                    appsettings.{Environment}.json files. To log SQL statements, add                        "Microsoft.EntityFrameworkCore.Database.Command": "Information" to the                  appsettings.Development.json file
20:30 - I add four arguments 
      - public int Id { get; set; }
        public string Productname { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
       
*******want rest ..... to busy schedule today .....lets work on tomorrow*******

13-10-2021
20:00 - I did same work to add AboutUs controller and 
21:30 - I took me a long time to set the aboutUs folder and made in run
21:37 - Lets run the program
21:40 - everything works preety will 
21:45 - I added 11 types of buckles in the home page.
21:58 - Resigter my self using my personal credentials
22:24 - download images from google to apply it in css
22:45 - Add varity of css like
      - font style
      - font family
      - include image
      - image css
      - background color
00:40 - finally the assignment was completely done looking awesome.......
after lot of hardwork.... feeling great.....forgetable moment....
