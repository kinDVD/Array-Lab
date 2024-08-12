/*Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.

What will the application do?
2 Points: Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
1 Point: Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.
1 Point: Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
1 Point: Ask the user if they would like to learn about another student.

Build Specifications:
1 Point: Validate user number: Use an if statement to check if the number is out of range, i.e. either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.
1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question. (See hints below!)
1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.

Hints:
Make sure the arrays are the same size.
Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
For the valid category: You might create a separate program to test out some code that uses a while loop and asks for either “Hometown” or “Favorite Food.” And only finishes the loop if either of these two is entered. Once you have it working, copy the code over to your “real” code.
Make it easy for the user – tell them what information is available
Try to use good grammar. Make your messages polite.

Extra Challenges:
1 Point: Provide an option where the user can see a list of all students.
2 Points: Allow the user to search by student name (Good challenge but difficult!)
1 Point: Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"
*/

using System.ComponentModel.Design;

bool runProgram = true;
while (runProgram)
{
    string[] names = new string[]
    {
    "Justin Jones",
    "DeAngelo Robinson",
    "Martina Basquez",
    "Alain Rene",
    "David Goodwin",
    "Joey Molinski",
    "Wren Grasley",
    "Brady Hartman",
    "David Brameijer",
    "Afseen Salam",
    "Ethan Thomas"
    };

    string[] hometowns = new string[]
    {
    "Westerville",
    "Detroit",
    "Edinburg",
    "Homestead",
    "Jersey City",
    "Toledo",
    "Richmond",
    "Saranac",
    "Grand Rapids",
    "India",
    "Bolivar"
    };

    string[] favoriteFoods = new string[]
    {
    "Baja Blast",
    "Pizza",
    "Leftovers",
    "Chicken Wings",
    "Sushi",
    "Dill Pickles",
    "Pizza",
    "Chicken Wings",
    "Tacos",
    "Shawarma",
    "Grapes"
    };

    Console.WriteLine("Weclome! Which student would you like to know more about? Enter a number 1-9 for a particular student, or enter \"Students\" to see all.");
    string student = Console.ReadLine().ToLower();
    int NumStud = int.Parse(student);
    //bool sf = false;
    string StudentSel = StudentName(NumStud, names);
    string domicile = StudentHome(NumStud, hometowns);
    string munchies = StudentHome(NumStud, favoriteFoods);

    if (student == "students")
    {
        foreach (string namest in names)
        {
            Console.WriteLine(namest);
        }
    }
    //else if (sf = true)
    //{

    //    string studentSearch = StudentFind(student, names);
    //    Console.WriteLine($"You selected{studentSearch}. Enter \"Hometown\" or \"Favorite Food.\"");
    //}
    else if (student != "student" && NumStud >= 1 && NumStud <= 9)
    {
        Console.WriteLine($"{student} is {StudentSel}. What would you like to know? Enter \"Hometown\" or \"Favorite Food.\"");
    }
    else
    {
        Console.WriteLine("That entry was invalid");
        continue;
    }

    string info = Console.ReadLine().ToLower();

    if (info == "hometown")
    {

        Console.WriteLine($"{StudentSel} is from {domicile}.");
    }
    else if (info == "favorite food")
    {

        Console.WriteLine($"{StudentSel}'s favorite food is {munchies}.");
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }

    static string StudentFind(string student,string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (student == names[i])
            {
                student = names[i];
                bool sf = true;
            }
            else if (student != names[i])
            {
                string notFound = "Invalid input. Please try again.";
                Console.WriteLine(notFound);
                break;
            }
        }return student;
    }
    static string StudentName(int Numstud, string[] names)
    {
        if (Numstud >= 1 && Numstud <= names.Length)
        {
            return names[Numstud];
        }
        else
        {
            string notFound = "Invalid input. Please try again.";
            return notFound;
        }
    }
    static string StudentHome(int Numstud, string[] hometowns)
    {
        if (Numstud >= 1 && Numstud <= hometowns.Length)
        {
            return hometowns[Numstud];
        }
        else
        {
            string notFound = "Invalid input. Please try again.";
            return notFound;
        }
    }
    static string StudentFood(int Numstud, string[] favoriteFoods)
    {
        if (Numstud >= 1 && Numstud <= favoriteFoods.Length)
        {
            return favoriteFoods[Numstud];
        }
        else
        {
            string notFound = "Invalid input. Please try again.";
            return notFound;
        }
    }

    while (runProgram = true)
    {
        Console.WriteLine($"Would you like to learn about another student? y/n");
        string again = Console.ReadLine();
        Console.WriteLine();

        if (again == "y")
        {
            runProgram = true;
            break;
        }
        else if (again == "n")
        {
            Console.WriteLine($"Thanks.");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid selection, you donk.");
            Console.WriteLine();
            continue;
        }
    }
}