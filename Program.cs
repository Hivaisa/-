// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string alphabet = "abcdefghijklmnopqrstuvwxyz";

Console.Write("Please enter the sender's name (only English letters): ");
string sender = Console.ReadLine(); 


Console.Write("Please enter the receiver's name (only English letters): ");
string receiver = Console.ReadLine(); 


int senderSum = 0;
foreach (char c in sender.ToLower()) 
{
     if (char.IsLetter(c)) 
     {
        int index = alphabet.IndexOf(c); 
        senderSum += index; 
     }
}


int receiverSum = 0;
foreach (char c in receiver.ToLower()) 
{
    if (char.IsLetter(c)) 
    {
        int index = alphabet.IndexOf(c); 
        receiverSum += index; 
    }
}

int shift = (senderSum + receiverSum) % 26;
Console.WriteLine("The shift value is: " + shift);

Console.Write("Please enter the message to encrypt (only English letters): ");
string message = Console.ReadLine(); 


string encryptedMessage = "";
foreach (char c in message.ToLower()) 
{
    if (char.IsLetter(c)) 
    {
        int index = (alphabet.IndexOf(c) + shift) % 26; 
        encryptedMessage += alphabet[index]; 
    }
    else
    {
        encryptedMessage += c; 
    }
}
Console.WriteLine("Encrypted message: " + encryptedMessage);

string decryptedMessage = "";
foreach (char c in encryptedMessage.ToLower()) 
{
    if (char.IsLetter(c))
    {
        int index = (alphabet.IndexOf(c) - shift + 26) % 26;
        decryptedMessage += alphabet[index];
    }
    else
    {
        decryptedMessage += c; 
    }
}
Console.WriteLine("Decrypted message: " + decryptedMessage);
    
