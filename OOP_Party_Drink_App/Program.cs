
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static UserDatabase userDb = new UserDatabase();
    static CocktailDatabase cocktailDb = new CocktailDatabase();

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        cocktailDb.SeedSampleCocktails();

        Console.WriteLine("🍸 Welcome to the Party Drink App! 🍹");

        User currentUser = null;

        while (currentUser == null)
        {
            Console.WriteLine("\n1. Login");
            Console.WriteLine("2. Register");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            if (option == "1")
                currentUser = Login();
            else if (option == "2")
                currentUser = Register();
            else
                Console.WriteLine("Invalid selection. Try again.");
        }

        Console.WriteLine($"Hello, { currentUser.Username}!");

        Console.WriteLine($"Hello, {currentUser.Username}!");

        if (currentUser.DislikedFlavors == null || currentUser.DislikedFlavors.Count == 0)
        {
            AskPreferences(currentUser);
            userDb.UpdateUser(currentUser); // artık sadece update
        }

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. Suggest me a cocktail");
            Console.WriteLine("3. Exit");
            Console.Write("Choose: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                ShowProfile(currentUser);
            }
            else if (input == "2")
            {
                var allCocktails = cocktailDb.GetAllCocktails();
                var engine = new RecommendationEngine();
                var suggestions = engine.Recommend(currentUser, allCocktails);

                Console.WriteLine("\n🍹 Recommended Cocktails:");
                foreach (var drink in suggestions)
                    Console.WriteLine($"- {drink.Name}");
            }
            else if (input == "3")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("❌ Invalid selection.");
            }
        }
    }

    static User Login()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var user = userDb.GetUser(username, password);
        if (user != null)
        {
            Console.WriteLine("✅ Login successful!");
            return user;
        }

        Console.WriteLine("❌ Invalid credentials.");
        return null;
    }

    static User Register()
    {
        Console.Write("Choose a username: ");
        string username = Console.ReadLine();

        if (userDb.UserExists(username))
        {
            Console.WriteLine("🚫 Username already exists.");
            return null;
        }

        Console.Write("Choose a password: ");
        string password = Console.ReadLine();

        var newUser = new User { Username = username, Password = password };
        AskPreferences(newUser);                  // ⬅️ 1) ANKETİ BURADA SOR
        userDb.InsertUser(newUser);               // ⬅️ 2) USER’I BURADA KAYDET

        return newUser;
    }

    static List<string> AvailableFlavors = new List<string> {
    "mint", "coconut", "coffee", "orange", "lemon", "lime", "strawberry", "pineapple",
    "chocolate", "blueberry", "cream", "vodka", "rum", "whiskey", "gin", "tequila"
};

    static void AskPreferences(User user)
    {
        user.Taste = AskEnumSelection<TasteProfile>("What is your preferred taste profile?");
        user.Alcohol = AskEnumSelection<AlcoholPreference>("Do you prefer alcoholic or non-alcoholic drinks?");
        user.Temperature = AskEnumSelection<TemperaturePreference>("What kind of temperature do you prefer?");
        user.Creamy = AskEnumSelection<CreamyPreference>("Do you enjoy creamy drinks?");
        user.Adventurousness = AskEnumSelection<FlavorOpenness>("How adventurous are you with trying new flavors?");

        // Disliked Flavors: Şıkla ve çoklu seçimle
        user.DislikedFlavors = new List<string>();
        bool addMore = true;
        while (addMore)
        {
            Console.WriteLine("\nWhich flavor do you dislike?");
            for (int i = 0; i < AvailableFlavors.Count; i++)
                Console.WriteLine($"{i + 1}. {AvailableFlavors[i]}");
            Console.Write("Enter the number of the flavor you dislike (or 0 to finish): ");

            if (int.TryParse(Console.ReadLine(), out int selection) &&
                selection > 0 && selection <= AvailableFlavors.Count)
            {
                string selectedFlavor = AvailableFlavors[selection - 1];
                if (!user.DislikedFlavors.Contains(selectedFlavor))
                    user.DislikedFlavors.Add(selectedFlavor);

                Console.Write("Do you want to add another disliked flavor? (yes/no): ");
                string again = Console.ReadLine().Trim().ToLower();
                addMore = (again == "yes" || again == "y");
            }
            else
            {
                addMore = false;
            }
        }

        user.DrinkOccasion = AskEnumSelection<Occasion>("Which type of occasion do you usually drink for?");
        user.Sweetness = AskEnumSelection<SweetnessLevel>("How much sweetness do you enjoy?");
    }

    static void ShowProfile(User user)
    {
        Console.WriteLine("\n👤 Your Profile:");
        Console.WriteLine($"Taste: {user.Taste}");
        Console.WriteLine($"Alcohol: {user.Alcohol}");
        Console.WriteLine($"Temperature: {user.Temperature}");
        Console.WriteLine($"Creamy: {user.Creamy}");
        Console.WriteLine($"Adventurousness: {user.Adventurousness}");
        Console.WriteLine($"Disliked Flavors: {user.DislikedFlavors}");
        Console.WriteLine($"Occasion: {user.DrinkOccasion}");
        Console.WriteLine($"Sweetness: {user.Sweetness}");
    }

    static T AskEnumSelection<T>(string question) where T : Enum
    {
        Console.WriteLine($"{ question}   ");
        var values = Enum.GetValues(typeof(T)).Cast<T>().ToList();

        for (int i = 0; i < values.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {values[i]}");
        }

        int selection;
        while (true)
        {
            Console.Write("Enter choice number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out selection) && selection >= 1 && selection <= values.Count)
            {
                return values[selection - 1];
            }
            Console.WriteLine("❌ Invalid selection. Try again.");
        }
    }
}
