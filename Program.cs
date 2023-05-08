using System;

class GameEngine {
    static void Main(string[] args) {
        Console.WriteLine("Welcome to My Game!");

        // Define game logic and structure
        Player player = new Player();
        Room room1 = new Room("Room 1", "You are in a dark room.");
        Room room2 = new Room("Room 2", "You are in a brightly lit room.");
        player.CurrentRoom = room1;

        // Implement game user interface and flow
        string command = "";
        while (command != "quit") {
            Console.WriteLine(player.CurrentRoom.Description);
            Console.Write("> ");
            command = Console.ReadLine();

            if (command == "go east") {
                player.CurrentRoom = room2;
            } else if (command == "go west") {
                player.CurrentRoom = room1;
            } else {
                Console.WriteLine("Invalid command.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}

class Player {
    public Room CurrentRoom { get; set; }
}

class Room {
    public string Name { get; set; }
    public string Description { get; set; }

    public Room(string name, string description) {
        Name = name;
        Description = description;
    }
}
