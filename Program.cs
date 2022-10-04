// See https://aka.ms/new-console-template for more information


int gPoints = 300;
Game:

// Is the point 0? if yes game over if not ask if player want to continue if yes contiue of not game over
    // This will generate the first number
    Random rnd = new Random();
    int num = rnd.Next(1, 13);
    Console.WriteLine("The card is: "+num);

    // This will generate the next number
    int nnum = rnd.Next(1, 13);

    // This is where the user will guess
    Console.WriteLine("Higher or lower? [h/l] ");
    string uGuess = Console.ReadLine()??"";

    Console.WriteLine("Next card was: "+nnum);

    // An if condition if correct +100 if not -75
    if (uGuess == "h" || uGuess == "H"){
        if (nnum > num){
            gPoints += 100;
        }
        else {
            gPoints -= 75;
        }
    }
    if (uGuess == "l" || uGuess == "L"){
        if (nnum > num){
            gPoints -= 75;
        }
        else {
            gPoints += 100;
        }
    }

    // This is the score
    Console.WriteLine("Your score is: "+gPoints);

    if (gPoints > 0){
        Console.WriteLine("Play again? [y/n] ");
        string uPlay = Console.ReadLine()??"";
        if (uPlay == "y" || uPlay == "Y") {
            goto Game;
        }
        if (uPlay == "n" || uPlay == "N") {
            Console.WriteLine("Game over! Thank you for playing");
        }
    }
    else{
        Console.WriteLine("Game over! Thank you for playing");
    }

